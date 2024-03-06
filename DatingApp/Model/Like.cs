using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        [ForeignKey("LikerId")]
        public virtual UserProfile Liker { get; set; } = null!;

        [ForeignKey("LikeeId")]
        public virtual UserProfile Likee { get; set; } = null!;

    }
}
