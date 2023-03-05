﻿using System.ComponentModel.DataAnnotations;

namespace DesignProject.Models
{
    public class Author
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? FirstName { get; set; }
        [Required]
        public string? LastName { get; set; }

        public virtual ICollection<Book>? Books { get; set; }
    }
}
