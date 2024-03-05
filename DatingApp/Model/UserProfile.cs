using DatingApp.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DatingApp.Models
{
    public class UserProfile
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }

        [Required(ErrorMessage = "Please provide a User Name")]
        [StringLength(100)]
        public string UserName { get; set; } = null!;

        [Required(ErrorMessage = "Please provide a Birth Date")]
        public DateTime BirthDate { get; set; }

        [Range(50, 300)]
        public int Height { get; set; }

        public string? AboutMe { get; set; }

        [EnumDataType(typeof(Gender), ErrorMessage = "Please Select a Gender")]
        public Gender Gender { get; set; }

        public string CityName { get; set; }

        public string Hobbies { get; set; }

        // Navigation property for self-referencing many-to-many relationship
        public virtual ICollection<Like> LikedByUsers { get; set; } = new List<Like>();
        public virtual ICollection<Like> LikedUsers { get; set; } = new List<Like>();

        // Navigation property for self-referencing many-to-many relationship
        public virtual ICollection<Message> SentByUsers { get; set; } = new List<Message>();
        public virtual ICollection<Message> ReceivedByUsers { get; set; } = new List<Message>();

        public User User { get; set; }
    }
}
