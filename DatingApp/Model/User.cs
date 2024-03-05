using System.ComponentModel.DataAnnotations;

namespace DatingApp.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please provide a First Name")]
        [StringLength(100)]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please provide a Last Name")]
        [StringLength(100)]
        public string LastName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please provide a Email Name")]
        [StringLength(100)]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please provide a Login Name")]
        [StringLength(100)]
        public string Login { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please provide a Password Name")]
        [StringLength(100)]
        public string Password { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please provide a Password2 Name")]
        [StringLength(100)]
        public string Password2 { get; set; } = string.Empty;

        public DateTime CreateDate { get; set; }

        public DateTime? DeleteDate { get; set; }

        public UserProfile UserProfile { get; set; }

    }
}
