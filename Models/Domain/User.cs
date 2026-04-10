namespace portfoliotracker.Models.Domain
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateOnly DateCreated { get; set; }
        public Boolean IsDeleted { get; set; }

    }
}
