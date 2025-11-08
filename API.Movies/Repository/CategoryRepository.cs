using API.Movies.DAL;
using API.Movies.DAL.Models;
using API.Movies.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace API.Movies.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        //patron creacion de dependencias:

        private readonly ApplicationDbContext _context;
        public CategoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<bool> CategoryExistsByIdAsync(int id)
        
        {
            return await _context.Categories.AsNoTracking().AnyAsync(c => c.Id == id);
        }

        public async Task<bool> CategoryExistsByNameAsync(string name)
        {
            return await _context.Categories.AsNoTracking().AnyAsync(c => c.Name == name);
        }

        public Task<bool> CreateCategoryAsync(Category category)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteCategoryAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<Category>> GetCategoriesAsync()
        {
            return await _context.Categories.AsNoTracking().OrderBy(c => c.Name).ToListAsync();

        }

        public async Task<Category> GetCategoryAsync(int id)//async y await para operaciones asincronas
        {
            return await _context.Categories.AsNoTracking().FirstOrDefaultAsync(c => c.Id == id);

            
        }

        public Task<bool> UpdateCategoryAsync(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
