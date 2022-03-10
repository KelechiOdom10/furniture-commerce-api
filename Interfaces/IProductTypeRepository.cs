using API.Entities;

namespace API.Interfaces;

public interface IProductTypeRepository
{
    Task<IReadOnlyList<ProductType>> GetProductTypesAsync();
    Task<ProductType> GetProductTypeByIdAsync(Guid id);
    Task<ProductType> GetProductTypeByNameAsync(string name);
    Task<bool> AddProductTypeAsync(ProductType productType);
    Task<bool> UpdateProductTypeAsync(ProductType productType);
    Task<bool> DeleteProductTypeByIdAsync(Guid id);
}