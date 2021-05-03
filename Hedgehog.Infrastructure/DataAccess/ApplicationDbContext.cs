using Hedgehog.Core.Application;
using Hedgehog.Core.Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace Hedgehog.Infrastructure.DataAccess
{
    public class ApplicationDbContext : IdentityDbContext<HedgehogUserAccount>
    {
        public DbSet<WebStore> WebStores;
        public DbSet<Product> Products;
        public DbSet<Order> Orders;
        public DbSet<OrderItem> OrderItems;
        public DbSet<Address> Addresses;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UserAccount>(
                entityBuilder =>
                {
                    //entityBuilder.Property(u => u.WebStore).HasColumnName("RelatedWebStore").IsRequired();
                    entityBuilder.HasBaseType(typeof(HedgehogUserAccount));
                });

            modelBuilder.Entity<CustomerAccount>(
                entityBuilder =>
                {
                    //entityBuilder.Property(c => c.WebStore).HasColumnName("RelatedWebStore").IsRequired();
                    entityBuilder.HasBaseType(typeof(HedgehogUserAccount));
                });

            modelBuilder.Entity<HedgehogUserAccount>(
                entityBuilder =>
                {
                    entityBuilder.HasDiscriminator<string>("AccountType")
                                 .HasValue<CustomerAccount>("Customer")
                                 .HasValue<UserAccount>("User");
                    entityBuilder.HasBaseType(null as Type);
                    //entityBuilder.Property(account => account.CompanyName).HasColumnType("nvarchar(128)");//.IsRequired();
                });


            modelBuilder.Entity<WebStore>(
                entityBuilder =>
                {
                    entityBuilder.HasIndex(store => store.NavigationTitle).IsUnique();
                    //entityBuilder.HasOne<UserAccount>().WithOne(a=>a.WebStore).HasForeignKey<UserAccount>(x=>x.WebStoreId);
                    //entityBuilder.HasMany<CustomerAccount>().WithOne();
                });

            modelBuilder.Entity<Product>(
                entityBuilder =>
                {
                    entityBuilder.Property(product => product.ProductName).HasColumnType("nvarchar(256)");
                    entityBuilder.Property(product => product.ShortDescription).HasColumnType("nvarchar(1024)");
                    entityBuilder.Property(product => product.LongDescription).HasColumnType("nvarchar(max)");
                    entityBuilder.Property(product => product.ImageUrl).HasColumnType("nvarchar(1024)");
                });

            modelBuilder.Entity<OrderItem>(
                entityBuilder =>
                {
                    entityBuilder.Property(oi => oi.ProductName).HasColumnType("nvarchar(256)");
                    entityBuilder.Property(oi => oi.ProductShortDescription).HasColumnType("nvarchar(1024)");
                });

            modelBuilder.Entity<Address>(
                entityBuilder =>
                {
                    entityBuilder.Property(a => a.Receiver).HasColumnType("nvarchar(256)");
                    entityBuilder.Property(a => a.StreetAddress).HasColumnType("nvarchar(256)");
                    entityBuilder.Property(a => a.City).HasColumnType("nvarchar(256)");
                    entityBuilder.Property(a => a.Country).HasColumnType("nvarchar(256)");
                    entityBuilder.Property(a => a.ZipCode).HasColumnType("nvarchar(256)");
                });
        }

        private void SeedRoles(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Name = "User",
                    NormalizedName = "USER",
                    Id = "1"
                });

            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Name = "User",
                    NormalizedName = "USER",
                    Id = "2"
                });
        }
    }
}
