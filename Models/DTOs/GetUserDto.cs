using System.ComponentModel.DataAnnotations;

namespace portfoliotracker.Models.DTOs
{
    public class GetUserDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateOnly DateCreated { get; set; }
        public DateOnly? DateDeleted { get; set; }
        public string? Address { get; set; }
        public int? Postcode { get; set; }
        public string? State { get; set; }
    }
}
