using API.Movies.DAL.Models;

namespace API.Movies.Services.IServices
{
    public interface ICategoryService
    {
        Task<ICollection<Category>> GetCategoriesAsync(); //Me retorna lista de categorias
        Task<Category> GetCategoryAsync(int id);//Me retorna una categoría por ID
        Task<bool> CategoryExistsByIdAsync(int id);//Me retorna si existe una cat pot ID
        Task<bool> CategoryExistsByNameAsync(string name);//Existe una cat por Name
        Task<bool> CreateCategoryAsync(Category category);//Crea una categoría

        Task<bool> DeleteCategoryAsync(int id);

        Task<bool> UpdateCategoryAsync(Category category);
    }
}
