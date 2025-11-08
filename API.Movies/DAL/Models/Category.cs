using System.ComponentModel.DataAnnotations;

namespace API.Movies.DAL.Models
{
    public class Category : AuditBase
    {

       
        [Required]
        public string Name { get; set; }
    }
}
