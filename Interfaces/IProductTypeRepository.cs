using API.Entities;

namespace API.Interfaces;

public interface IProductTypeRepository
{
    Task<IReadOnlyList<ProductType>> GetProductTypesAsync();
    Task<ProductType?> GetProductTypeByIdAsync(int id);
    Task<ProductType?> GetProductTypeBySlugAsync(string slug);
    Task<ProductType?> AddProductTypeAsync(ProductType productType);
    Task<bool> UpdateProductTypeAsync(ProductType productType);
    Task<bool> DeleteProductTypeByIdAsync(int id);
}