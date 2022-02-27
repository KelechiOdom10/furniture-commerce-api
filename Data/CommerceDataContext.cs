using System;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class CommerceDataContext : DbContext
{
    public CommerceDataContext(DbContextOptions<CommerceDataContext> options) :
        base(options)
    {
        Database.EnsureCreated();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>().HasIndex(c => c.Name).IsUnique();
        modelBuilder.Entity<Category>().HasMany(c => c.Products).WithOne(p => p.Category).HasForeignKey(p => p.CategoryId);
    }

    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }

}


