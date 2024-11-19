using System.ComponentModel.DataAnnotations;

namespace ApplicantAPI.Models.Entities
{
    public class Applicant
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public required string FirstName { get; set; }
        [MaxLength(50)]
        public string MiddleName { get; set; }
        [MaxLength(50)]
        public required string LastName { get; set; }
        public string? PhoneNumber { get; set; }
        [Required]
        [EmailAddress(ErrorMessage = "Invalid email address format.")]
        public required string Email { get; set; }
        public required string Comment { get; set; }
        public string? LinkedIn { get; set; }
        public string? GitHub { get; set; }
    }
}
