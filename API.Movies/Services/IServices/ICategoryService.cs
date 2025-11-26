using API.Movies.DAL.Models;
using API.Movies.DAL.Models.Dtos;

namespace API.Movies.Services.IServices
{
    public interface ICategoryService
    {
        Task<ICollection<CategoryDto>> GetCategoriesAsync(); //Me retorna lista de categorias
        Task<CategoryDto> GetCategoryAsync(int id);//Me retorna una categoría por ID
        Task<bool> CategoryExistsByIdAsync(int id);//Me retorna si existe una cat pot ID
        Task<bool> CategoryExistsByNameAsync(string name);//Existe una cat por Name
        Task<CategoryDto> CreateCategoryAsync(CategoryCreateUpdateDto categoryDto);//Crea una categoría

        Task<bool> DeleteCategoryAsync(int id);

        Task<CategoryDto> UpdateCategoryAsync(CategoryCreateUpdateDto dto,int id);
    }
}
