using API.Entities;

namespace API.Interfaces
{
    public interface ICategoryRepository
    {
        Task<IReadOnlyList<Category>> GetCategoriesAsync();
        Task<Category> GetCategoryByIdAsync(Guid id);
        Task<Category> GetCategoryByNameAsync(string name);
        Task<bool> AddCategoryAsync(Category category);
        Task<bool> UpdateCategoryAsync(Category category);
        Task<bool> DeleteCategoryByIdAsync(Guid id);
    }
}