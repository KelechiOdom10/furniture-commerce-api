using API.Entities;
using Microsoft.EntityFrameworkCore;
using API.Extensions;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace API.Data;

public class CommerceDataContext : IdentityDbContext<User>
{
    public CommerceDataContext(DbContextOptions<CommerceDataContext> options) :
        base(options)
    {
        Database.EnsureCreated();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Category>().HasIndex(c => c.Name).IsUnique();
        modelBuilder.Entity<Category>().HasIndex(p => p.Slug).IsUnique();
        modelBuilder.Entity<Category>().HasMany(c => c.Products).WithOne(p => p.Category).HasForeignKey(p => p.CategoryId);
        modelBuilder.Entity<Category>().HasMany(c => c.ProductTypes).WithOne(pt => pt.Category).HasForeignKey(pt => pt.CategoryId);

        modelBuilder.Entity<ProductType>().HasIndex(pt => pt.Name).IsUnique();
        modelBuilder.Entity<ProductType>().HasIndex(pt => pt.Slug).IsUnique();
        modelBuilder.Entity<ProductType>().HasMany(pt => pt.Products).WithOne(p => p.ProductType).HasForeignKey(p => p.ProductTypeId);

        modelBuilder.Entity<Product>().HasIndex(p => p.Slug).IsUnique();
        modelBuilder.Entity<Product>().HasIndex(p => p.Name).IsUnique();

        modelBuilder.Entity<User>().HasMany(u => u.Addresses).WithOne(a => a.User).HasForeignKey(a => a.UserId);

        modelBuilder.Seed();

    }

    public DbSet<Category> Categories => Set<Category>();
    public DbSet<Product> Products => Set<Product>();
    public DbSet<ProductType> ProductTypes => Set<ProductType>();

}


