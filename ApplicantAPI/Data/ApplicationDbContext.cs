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

    }
}
