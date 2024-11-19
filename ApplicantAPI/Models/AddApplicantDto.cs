using System.ComponentModel.DataAnnotations;

namespace ApplicantAPI.Models
{
    public class AddApplicantDto
    {
        [MaxLength(50)]
        public required string FirstName { get; set; }
        [MaxLength(50)]
        public string MiddleName { get; set; }
        [MaxLength(50)]
        public required string LastName { get; set; }
        public string? PhoneNumber { get; set; }
        public required string Email { get; set; }
        public required string Comment { get; set; }
        public string? LinkedIn { get; set; }
        public string? GitHub { get; set; }
    }
}
