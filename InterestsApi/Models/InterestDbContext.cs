using Microsoft.EntityFrameworkCore;

namespace InterestsApi.Models
{
    public class InterestDbContext : DbContext
    {
        public InterestDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Interest> Interests { get; set; }
        public DbSet<Website> Websites { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Interest>()
                .HasData(
                new { Id = 1, Name = "Fiske", UserId = 1 },
                new { Id = 2, Name = "Höjdhopp", Url = "www.hojdhopp.se", UserId = 2 },
                new { Id = 3, Name = "Utveckling", Url = "www.stackoverflow.com", UserId = 3 }
                );
            modelBuilder.Entity<User>()
                .HasData(
                new { Id = 1, Name = "Erik Filipsson", PhoneNumber = "070-3272032" },
                new { Id = 2, Name = "Dina Digiorno", PhoneNumber = "070-6224012" },
                new { Id = 3, Name = "Simona Ryd", PhoneNumber = "070-7823122" }
                );
            modelBuilder.Entity<Website>()
                .HasData(
                new { Id = 1, Title = "Edge Flyfishing Forum", Url = "www.edgeflyfishing.com", InterestId = 1 },
                new { Id = 2, Title = "Nedre Ljungan", Url = "www.flugfiskenedreljungan.com", InterestId = 1 },
                new { Id = 3, Title = "Höjdhopparna", Url = "www.hojdhopp.se", InterestId = 2 },
                new { Id = 4, Title = "Utvecklarforum", Url = "www.stackoverflow.com", InterestId = 3 }
                );
        }
    }
}
