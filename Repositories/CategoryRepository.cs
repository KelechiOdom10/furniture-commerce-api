
using Microsoft.EntityFrameworkCore;
using API.Interfaces;
using API.Entities;
using API.Data;

namespace API.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly CommerceDataContext _context;
        public CategoryRepository(CommerceDataContext context)
        {
            _context = context;
        }

        public async Task<Category> GetCategoryByIdAsync(Guid id)
        {
            return await _context.Categories.FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<IReadOnlyList<Category>> GetCategoriesAsync()
        {
            return await _context.Categories.ToListAsync();
        }

        public async Task<Category> GetCategoryByNameAsync(string name)
        {
            return await _context.Categories.FirstOrDefaultAsync(c => c.Name == name);
        }

        public async Task<bool> AddCategoryAsync(Category category)
        {
            await _context.Categories.AddAsync(category);
            return await SaveAsync();
        }

        public async Task<bool> UpdateCategoryAsync(Category category)
        {
            _context.Categories.Update(category);
            return await SaveAsync();
        }

        public async Task<bool> DeleteCategoryByIdAsync(Guid id)
        {
            var category = await _context.Categories.FindAsync(id);
            if (category == null)
                return false;

            _context.Categories.Remove(category);
            return await SaveAsync();
        }

        private async Task<bool> SaveAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}