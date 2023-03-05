using System.ComponentModel.DataAnnotations;

namespace DesignProject.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Title { get; set; }
        public string? Publisher { get; set; }
        [Required]
        public string? ISBN { get; set; }
        public string? Format { get; set; }

        public virtual ICollection<Copy>? Copies { get; set; }
        public virtual ICollection<Hold>? Holds { get; set; } 
        public virtual ICollection<Author>? Authors { get; set; }
        public virtual ICollection<Genre>? Genres { get; set; }

    }
}
