using Microsoft.EntityFrameworkCore;

namespace portfoliotracker.Models.Domain
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateOnly DateCreated { get; private set; }
        public DateOnly? DateDeleted { get;private set; }
        public string? Address { get; set; }
        public int? Postcode { get; set; }
        public string? State { get; set; }
        public List<Portfolio> Portfolios { get; set; }= new List<Portfolio>();
        public User()
        {
            DateCreated = DateOnly.FromDateTime(DateTime.Now);
        }

        public void Delete()
        {
            this.DateDeleted = DateOnly.FromDateTime(DateTime.Now);
            this.Portfolios.ForEach(x => x.Deactivate());
        }

    }
}
