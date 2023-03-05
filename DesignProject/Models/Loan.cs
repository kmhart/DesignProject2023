using System.ComponentModel.DataAnnotations;

namespace DesignProject.Models
{
    public class Loan
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime? StartDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        [Required]
        public int? LoanDuration { get; set; }
        [Required]
        public bool? Active { get; set; } = false;

        public int? CopyId { get; set; }
        public Copy? Copy { get; set; }

        public string? MemberLibraryCardNo { get; set; }
        public Member? Member { get; set; }

    }
}
