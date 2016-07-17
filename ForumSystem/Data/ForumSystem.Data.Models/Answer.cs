﻿namespace ForumSystem.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Answer
    {
        public Answer()
        {
            this.Comments = new HashSet<Comment>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100000, MinimumLength = 12, ErrorMessage = "The {0} must be between {1} and {2} symbols.")]
        public string Content { get; set; }

        public int PostId { get; set; }

        public virtual Post Post { get; set; }

        public string AuthorId { get; set; }

        public virtual ApplicationUser Author { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
    }
}