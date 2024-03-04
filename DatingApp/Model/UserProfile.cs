using DatingApp.Models;
using System.ComponentModel.DataAnnotations;

namespace DatingApp.Models
{
    public class UserProfile
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please provide a User Name")]
        [StringLength(100)]
        public string UserName { get; set; } = null!;

        [Required(ErrorMessage = "Please provide a Birth Date")]
        public DateTime BirthDate { get; set; }

        [Range(50, 300)]
        public int Height { get; set; }

        public string? AboutMe { get; set; }

        [Required(ErrorMessage = "Please provide a Valid City Id")]

        public int CityId { get; set; }
        [Required(ErrorMessage = "Please provide a Valid User Id")]
        public int UserId { get; set; }

        // Navigation property for self-referencing many-to-many relationship
        public virtual ICollection<Like> LikedByUsers { get; set; } = new List<Like>();
        public virtual ICollection<Like> LikedUsers { get; set; } = new List<Like>();

        // Navigation property for self-referencing many-to-many relationship
        public virtual ICollection<Message> SentByUsers { get; set; } = new List<Message>();
        public virtual ICollection<Message> ReceivedByUsers { get; set; } = new List<Message>();

    }
}
