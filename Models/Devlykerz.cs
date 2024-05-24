using System.ComponentModel.DataAnnotations;
using System.Security.Principal;

namespace Devlyk.Models
{
    public class Devlykerz
    {
        [Key]
        public Guid Id { get; set; } =Guid.NewGuid();

        [Required(ErrorMessage ="UserName is required")]
        
        public string UserName { get; set; }

        [Required(ErrorMessage ="FirstName is required")]
        public string FirstName { get; set; }

        public string? LastName { get; set; }

        [Required(ErrorMessage ="Email is required")]
        [EmailAddress(ErrorMessage ="Please enter a valid email address")]
        public string Email { get; set; }


    }
}
