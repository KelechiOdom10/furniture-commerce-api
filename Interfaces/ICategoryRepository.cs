using API.Entities;

namespace API.Interfaces;

public interface ICategoryRepository
{
    Task<IReadOnlyList<Category>> GetCategoriesAsync();
    Task<Category> GetCategoryByIdAsync(int id);
    Task<Category> GetCategoryBySlugAsync(string GetProductTypeBySlugAsync);
    Task<Category> AddCategoryAsync(Category category);
    Task<bool> UpdateCategoryAsync(Category category);
    Task<bool> DeleteCategoryByIdAsync(int id);
}