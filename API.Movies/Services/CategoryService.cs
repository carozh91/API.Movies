using API.Movies.DAL.Models;
using API.Movies.Services.IServices;

namespace API.Movies.Services
{
    public class CategoryService: ICategoryService
    {
        private readonly ICategoryService _categoryService;
        public CategoryService()
        {
            
        }

        Task<bool> ICategoryService.CategoryExistsByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task<bool> ICategoryService.CategoryExistsByNameAsync(string name)
        {
            throw new NotImplementedException();
        }

        Task<bool> ICategoryService.CreateCategoryAsync(Category category)
        {
            throw new NotImplementedException();
        }

        Task<bool> ICategoryService.DeleteCategoryAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task<ICollection<Category>> ICategoryService.GetCategoriesAsync()
        {
            throw new NotImplementedException();
        }

        Task<Category> ICategoryService.GetCategoryAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task<bool> ICategoryService.UpdateCategoryAsync(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
