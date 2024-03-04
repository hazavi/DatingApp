using System.ComponentModel.DataAnnotations;

namespace DatingApp.Models
{
    public class Message
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please provide a valid Sender Id")]
        public int SenderId { get; set; }

        [Required(ErrorMessage = "Please provide a valid Receiver Id")]
        public int ReceiverId { get; set; }
        [Required(ErrorMessage = "Please provide a Status")]
        public int Status { get; set; } = 0;

        [Required(ErrorMessage = "Please provide a Message. At least 2 letters required")]
        [MinLength(2, ErrorMessage = "Use at least 2 letters")]
        public string Msg { get; set; } = null!;

        public virtual UserProfile Sender { get; set; } = null!;
        public virtual UserProfile Receiver { get; set; } = null!;
    }
}
