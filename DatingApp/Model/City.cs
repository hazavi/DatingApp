using System.ComponentModel.DataAnnotations;

namespace DatingApp.Models
{
    public class City
    {
        public City()
        {
            UserProfile = new List<UserProfile>();
        }
        public int Id { get; set; }

        [Required(ErrorMessage = "Please provide a City Name")]
        [StringLength(10)]
        public string CityName { get; set; } = null!;

        public List<UserProfile> UserProfile { get; set; }
    }
}
