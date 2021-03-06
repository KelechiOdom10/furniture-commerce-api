using API.Data;
using API.Entities;
using API.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace API.Repositories;

public class ProductTypeRepository : IProductTypeRepository
{
    private readonly CommerceDataContext _context;

    public ProductTypeRepository(CommerceDataContext context)
    {
        _context = context;
    }

    public async Task<IReadOnlyList<ProductType>> GetProductTypesAsync()
    {
        var productTypes = await _context.ProductTypes
            .Include(p => p.Category)
            .Include(p => p.Products)
            .ToListAsync();
        return productTypes;
    }

    public async Task<ProductType?> GetProductTypeByIdAsync(int id)
    {
        var productType = await _context.ProductTypes
            .Include(p => p.Category)
            .Include(p => p.Products)
            .FirstOrDefaultAsync(p => p.Id == id);
        return productType;
    }

    public async Task<ProductType?> GetProductTypeBySlugAsync(string slug)
    {
        var productType = await _context.ProductTypes
            .Include(p => p.Category)
            .Include(p => p.Products)
            .FirstOrDefaultAsync(p => p.Slug == slug);
        return productType;
    }

    public async Task<ProductType?> AddProductTypeAsync(ProductType productType)
    {
        await _context.ProductTypes.AddAsync(productType);
        var result = await SaveAsync();
        if (!result) return null;

        var addedProductType = await GetProductTypeByIdAsync(productType.Id);
        return addedProductType;
    }

    public async Task<bool> UpdateProductTypeAsync(ProductType productType)
    {
        _context.ProductTypes.Update(productType);
        return await SaveAsync();
    }

    public async Task<bool> DeleteProductTypeByIdAsync(int id)
    {
        var productType = await _context.ProductTypes.FindAsync(id);
        if (productType == null)
        {
            return false;
        }
        _context.ProductTypes.Remove(productType);
        return await SaveAsync();
    }
    private async Task<bool> SaveAsync()
    {
        return await _context.SaveChangesAsync() > 0;
    }
}
