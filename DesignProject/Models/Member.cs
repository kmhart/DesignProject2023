using System.ComponentModel.DataAnnotations;

namespace DesignProject.Models
{
    public class Member
    {
        [Key]
        [Required]
        public string? LibraryCardNo { get; set; }
        [Required]
        public string? FirstName { get; set; }
        [Required]
        public string? LastName { get; set; }
        [Required]
        [EmailAddress]
        public string? Email { get; set; }
        [Required]
        [Phone]
        public string? Phone { get; set; }
        [Required]
        public string? Street { get; set; }
        [Required]
        public string? City { get; set; }
        [Required]
        public string? State { get; set; }
        [Required]
        [RegularExpression(@"^[0-9]{5}$|^[0-9]{5}-?[0-9]{4}$", ErrorMessage = "Invalid Zip format")]
        public string? ZipCode { get; set;}
        public string? Status { get; set; }

        public virtual ICollection<Hold>? Holds { get; set; }
        public virtual ICollection<Loan>? Loans { get; set; }
    }
}
