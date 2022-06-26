using API.Data;
using API.Entities;
using API.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace API.Repositories;

public class ProductRepository : IProductRepository
{
    private readonly CommerceDataContext _context;
    public ProductRepository(CommerceDataContext context)
    {
        _context = context;
    }

    public async Task<IReadOnlyList<Product>> GetProductsAsync()
    {
        var products = await _context.Products
            .Include(p => p.ProductType)
            .Include(p => p.Category)
            .ToListAsync();
        return products;
    }

    public async Task<Product?> GetProductByIdAsync(int id)
    {
        var product = await _context.Products
            .Include(p => p.ProductType)
            .Include(p => p.Category)
            .FirstOrDefaultAsync(p => p.Id == id);
        return product;
    }

    public async Task<Product?> GetProductBySlugAsync(string slug)
    {
        var product = await _context.Products
            .Include(p => p.ProductType)
            .Include(p => p.Category)
            .FirstOrDefaultAsync(p => p.Slug == slug);
        return product;
    }

    public async Task<Product?> AddProductAsync(Product product)
    {
        await _context.Products.AddAsync(product);
        var result = await SaveAsync();
        if (!result) return null;

        var addedProduct = await GetProductByIdAsync(product.Id);
        return addedProduct;
    }

    public async Task<bool> UpdateProductAsync(Product product)
    {
        _context.Products.Update(product);
        return await SaveAsync();
    }

    public async Task<bool> DeleteProductByIdAsync(int id)
    {
        var product = await _context.Products.FindAsync(id);
        if (product == null) return false;

        _context.Products.Remove(product);
        return await SaveAsync();
    }

    public async Task<bool> ProductExistsAsync(string name, string slug)
    {
        return await _context.Products.AnyAsync(p => p.Name == name || p.Slug == slug);
    }

    private async Task<bool> SaveAsync()
    {
        return await _context.SaveChangesAsync() > 0;
    }
}
