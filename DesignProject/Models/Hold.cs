using System.ComponentModel.DataAnnotations;

namespace DesignProject.Models
{
    public class Hold
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime? Date { get; set; }

        public int? BookId { get; set; }
        public Book? Book { get; set; }

        public string? MemberLibraryCardNo { get; set; }
        public Member? Member { get; set; }
    }
}
