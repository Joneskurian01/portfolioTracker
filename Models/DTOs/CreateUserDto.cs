namespace portfoliotracker.Models.DTOs
{
    public class CreateUserDto
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string? Address { get; set; }
        public int? Postcode { get; set; }
        public string? State { get; set; }
    }
}
