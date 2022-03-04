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
        return await _context.ProductTypes.ToListAsync();
    }

    public async Task<ProductType> GetProductTypeByIdAsync(Guid id)
    {
        return await _context.ProductTypes.FirstOrDefaultAsync(pt => pt.Id == id);
    }

    public async Task<ProductType> GetProductTypeByNameAsync(string name)
    {
        return await _context.ProductTypes.FirstOrDefaultAsync(pt => pt.Name == name);
    }

    public async Task<bool> AddProductTypeAsync(ProductType productType)
    {
        await _context.ProductTypes.AddAsync(productType);
        return await SaveAsync();
    }

    public async Task<bool> UpdateProductTypeAsync(ProductType productType)
    {
        _context.ProductTypes.Update(productType);
        return await SaveAsync();
    }

    public async Task<bool> DeleteProductTypeByIdAsync(Guid id)
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
