using System.ComponentModel.DataAnnotations;
using Microsoft.Extensions.Logging;

namespace WebApplication2.Models
{
    public class Adminstartor : User

    {

        [Key]
        public int AdminId { get; set; } 

        [Required]
        [StringLength(100)]
        public string Name { get; set; } 

        [Required]
        [EmailAddress]
        [StringLength(100)]
        public string Email { get; set; } 

        [Required]
        [StringLength(256)]
        public string PasswordHash { get; set; } 
        public DateTime DateCreated { get; set; } = DateTime.Now; 

        public bool IsActive { get; set; } = true; 

        // Navigation properties
        public virtual ICollection<Member> ManagedMembers { get; set; } = new List<Member>(); 
        public virtual ICollection<Event> ManagedEvents { get; set; } = new List<Event>(); 

    }
}
