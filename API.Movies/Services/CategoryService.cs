using API.Movies.DAL.Models;
using API.Movies.DAL.Models.Dtos;
using API.Movies.Repository.IRepository;
using API.Movies.Services.IServices;
using AutoMapper;

namespace API.Movies.Services
{
    public class CategoryService: ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;
        public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
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

        public Task<bool> ICategoryService.DeleteCategoryAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async  Task<ICollection<CategoryDto>> GetCategoriesAsync()
        {
            var categories = _categoryRepository.GetCategoriesAsync();
            return _mapper.Map<ICollection<CategoryDto>>(categories); 

        }

        Task<CategoryDto> ICategoryService.GetCategoryAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task<bool> ICategoryService.UpdateCategoryAsync(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
