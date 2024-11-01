using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class User
    {
        [Required]
        [EmailAddress]
        [StringLength(100)]
        public String Email { get; set; }

        [Required]
        [StringLength(256)]
        public String Password { get; set; }
    }
}
