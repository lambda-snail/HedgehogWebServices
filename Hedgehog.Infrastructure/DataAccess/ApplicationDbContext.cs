using Hedgehog.Core.Application;
using Hedgehog.Core.Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Hedgehog.Infrastructure.DataAccess
{
    public class ApplicationDbContext : IdentityDbContext<HedgehogUserAccount>
    {
        public DbSet<WebStore> WebStores;
        public DbSet<Product> Products;
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<HedgehogUserAccount>(
                entityBuilder =>
                {
                    //entityBuilder.Property(account => account.CompanyName).HasColumnType("nvarchar(128)");//.IsRequired();
                    entityBuilder.HasOne(account => account.WebStore).WithOne(store => store.Owner).HasForeignKey<WebStore>(store => store.HedgehogUserAccountForeignKey);
                });

            modelBuilder.Entity<WebStore>(
                entityBuilder =>
                {
                    entityBuilder.HasIndex(store => store.NavigationTitle).IsUnique();
                });

            modelBuilder.Entity<Product>(
                entityBuilder =>
                {
                    entityBuilder.Property(product => product.ProductName).HasColumnType("nvarchar(256)");
                    entityBuilder.Property(product => product.ShortDescription).HasColumnType("nvarchar(1024)");
                    entityBuilder.Property(product => product.LongDescription).HasColumnType("nvarchar(max)");
                    entityBuilder.Property(product => product.ImageUrl).HasColumnType("nvarchar(1024)");
                });
        }
    }
}
