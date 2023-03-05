using System.ComponentModel.DataAnnotations;

namespace DesignProject.Models
{
    public class Genre
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }

        public virtual ICollection<Book>? Books { get; set; }
    }
}
