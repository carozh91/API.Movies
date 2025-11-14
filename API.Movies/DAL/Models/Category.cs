using System.ComponentModel.DataAnnotations;

namespace API.Movies.DAL.Models
{
    public class Category : AuditBase
    {

        [Display(Name = "Nombre de la categoría")] //Me sirve para personalizar el nombre que se muestra en las vistas o mensajes de error
        [Required]
        public required string Name { get; set; }
    }
}
