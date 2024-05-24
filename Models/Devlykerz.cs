using System.ComponentModel.DataAnnotations;
using System.Security.Principal;

namespace Devlyk.Models
{
    public class Devlykerz
    {
        [Key]
        public Guid id { get; set; } =Guid.NewGuid();

        [Required(ErrorMessage ="name is required")]
        public string FirstName { get; set; }

        public string LastName { get; set; } = string.Empty;


    }
}
