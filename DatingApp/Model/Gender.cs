using System.ComponentModel.DataAnnotations;

namespace DatingApp.Models
{
    public class Gender
    {
        public Gender()
        {
            UserProfile = new List<UserProfile>();
        }

        [Required(ErrorMessage = "Please provide a City Name")]
        [StringLength(10)]
        public string Id { get; set; } = null!;

        public List<UserProfile> UserProfile { get; set; }
    }
}
