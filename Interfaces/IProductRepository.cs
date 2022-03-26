using API.Entities;

namespace API.Interfaces;

public interface IProductRepository
{
    Task<IReadOnlyList<Product>> GetProductsAsync();
    Task<Product> GetProductByIdAsync(int id);
    Task<Product> GetProductBySlugAsync(string slug);
    Task<Product> AddProductAsync(Product product);
    Task<bool> UpdateProductAsync(Product product);
    Task<bool> DeleteProductByIdAsync(int id);
    Task<bool> ProductExistsAsync(string name, string slug);
}
