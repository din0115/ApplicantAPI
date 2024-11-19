using ApplicantAPI.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApplicantAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Applicant> Applicants { get; set; }
        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries<Applicant>())
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Entity.LogDate = DateTime.UtcNow;
                }
                if (entry.State == EntityState.Modified)
                {
                    entry.Entity.UpdateDate = DateTime.UtcNow;
                }
            }
            return base.SaveChanges();
        }
    }
}
