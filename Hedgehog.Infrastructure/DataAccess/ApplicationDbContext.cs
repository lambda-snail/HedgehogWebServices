using Hedgehog.Core.Application;
using Hedgehog.Core.Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Hedgehog.Infrastructure.DataAccess
{
    public class ApplicationDbContext : IdentityDbContext<HedgehogUserBase>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ServiceUserAccount>(
                entityBuilder =>
                {
                    entityBuilder.Property(account => account.CompanyName).HasColumnType("nvarchar(128)").IsRequired();
                    entityBuilder.HasOne(account => account.WebStore).WithOne(store => store.Owner).HasForeignKey<WebStore>(store => store.ServiceUserAccountForeignKey);

                });

        }
    }
}
