using System.ComponentModel.DataAnnotations;

namespace DesignProject.Models
{
    public class Copy
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? SKU { get; set; }

        public int? BookID { get; set; }
        public Book? Book { get; set; }

        public virtual ICollection<Loan>? Loans { get; set; }
    }
}
