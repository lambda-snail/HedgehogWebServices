using Autofac;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Reflection;
using MediatR;
using Hedgehog.Infrastructure.DataAccess;
using Hedgehog.Core.Application;
using Microsoft.AspNetCore.Http;
using Hedgehog.Core.Domain;
using Hedgehog.Infrastructure.Services;
using Hedgehog.Core.Contracts.InfrastructureContracts;
using Hedgehog.UI.IdentityInfrastructure;
using Hedgehog.Core.Application.UserTypes;

namespace Hedgehog.UI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // ConfigureServices is where you register dependencies. This gets
        // called by the runtime before the ConfigureContainer method, below.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            services.AddMvc();

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddDatabaseDeveloperPageExceptionFilter();

            services.AddIdentity<HedgehogUserAccount, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders()
                .AddDefaultUI();

            services.AddIdentityCore<UserAccount>(
                    options => options.SignIn.RequireConfirmedAccount = true)
                    .AddRoles<IdentityRole>()
                    .AddEntityFrameworkStores<ApplicationDbContext>()
                    .AddTokenProvider<EmailTokenProvider<UserAccount>>(TokenOptions.DefaultEmailProvider)
                    .AddDefaultUI();

            services.AddIdentityCore<CustomerAccount>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddRoles<IdentityRole>()
                    .AddEntityFrameworkStores<ApplicationDbContext>()
                    .AddTokenProvider("Default", typeof(HedgehogEmailTwoFactorAuthentication<CustomerAccount>))
                    .AddClaimsPrincipalFactory<CustomerAccountClaimsPrincipalFactory>()
                    .AddDefaultUI();

            services.AddHttpContextAccessor();
            services.AddSession();

            services.AddControllersWithViews();
        }

        // ConfigureContainer is where you can register things directly
        // with Autofac. This runs after ConfigureServices so the things
        // here will override registrations made in ConfigureServices.
        // Don't build the container; that gets done for you by the factory.
        public void ConfigureContainer(ContainerBuilder builder)
        {
            // Needed by MediatR for Autofac
            // https://github.com/jbogard/MediatR/wiki
            builder
                .RegisterType<Mediator>()
                .As<IMediator>()
                .InstancePerLifetimeScope();

            builder.Register<ServiceFactory>(context =>
            {
                var c = context.Resolve<IComponentContext>();
                return t => c.Resolve(t);
            });
            // End MediatR related stuff

            builder.RegisterType<HedgehogEmailTwoFactorAuthentication<CustomerAccount>>()
                    .As<IUserTwoFactorTokenProvider<CustomerAccount>>()
                    .InstancePerLifetimeScope();

            builder.RegisterType<HttpContextAccessor>()
                   .As<IHttpContextAccessor>()
                   .SingleInstance();

            // Register domain things and MediatR requests and handlers using assembly scanning
            // Note: Not all dependencies should be InstancePerLifetimeScope()
            // https://autofaccn.readthedocs.io/en/latest/lifetime/instance-scope.html
            builder.RegisterAssemblyTypes(Assembly.Load("Hedgehog.Core"))
                   //.As(t => t.GetInterfaces().FirstOrDefault(i => i.Name == "I" + t.Name))
                   .AsImplementedInterfaces()
                   .InstancePerLifetimeScope(); // One instance per HTTP request in Autofac

            builder.RegisterType<JsonSerializer<Address>>().As<ISerializer<Address>>();
            builder.RegisterType<JsonSerializer<ShoppingCart>>().As<ISerializer<ShoppingCart>>();
            builder.RegisterType<ShoppingCart>().InstancePerLifetimeScope();

            builder.RegisterAssemblyTypes(Assembly.Load("Hedgehog.Infrastructure"))
                   .AsImplementedInterfaces()
                   .InstancePerLifetimeScope();
        }

        // Configure is where you add middleware. This is called after
        // ConfigureContainer. You can use IApplicationBuilder.ApplicationServices
        // here if you need to resolve things from the container.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSession();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}");
                endpoints.MapControllerRoute(
                    name: "userstore",
                    pattern: "{storeNavigationTitle}/{controller=Store}/{action=Index}");
                endpoints.MapRazorPages();
            });
        }
    }
}
