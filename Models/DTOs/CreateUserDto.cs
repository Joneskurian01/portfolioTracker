using System.ComponentModel.DataAnnotations;

namespace portfoliotracker.Models.DTOs
{
    public class CreateUserDto
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        [Required]
        [EmailAddress(ErrorMessage ="Invalid format")]
        public string Email { get; set; }
        public string? Address { get; set; }
        [Range(1000,9999, ErrorMessage ="Postcode must be valid 4-digit Australian Code")]
        public int? Postcode { get; set; }
        [RegularExpression("^(VIC|NSW|QLD|NT|SA|WA|TAS|ACT)$", ErrorMessage ="Please use state initials (e.g VIC, NSW)")]
        public string? State { get; set; }
    }
}
