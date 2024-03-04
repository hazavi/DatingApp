using System.ComponentModel.DataAnnotations;

namespace DatingApp.Models
{
    public class Like
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please provide a valid Liker Id")]
        public int LikerId { get; set; }

        [Required(ErrorMessage = "Please provide a valid Likee Id")]
        public int LikeeId { get; set; }
        public int Status { get; set; } = 0;

        public virtual UserProfile Liker { get; set; } = null!;
        public virtual UserProfile Likee { get; set; } = null!;

    }
}
