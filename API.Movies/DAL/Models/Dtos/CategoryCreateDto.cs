using System.ComponentModel.DataAnnotations;

namespace API.Movies.DAL.Models.Dtos
{
    public class CategoryCreateDto
    {
        [Required(ErrorMessage ="El nombre de la categoría es obligatorio")]
        [MaxLength(100, ErrorMessage ="El número máximo de caracteres es de 100")]
        public required string Name { get; set; }
    }
    }

