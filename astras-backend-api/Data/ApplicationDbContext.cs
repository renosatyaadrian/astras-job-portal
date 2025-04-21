using Microsoft.EntityFrameworkCore;
using Astras.JobPortal.API.Entities;

namespace Astras.JobPortal.API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {}

        public DbSet<Job> Jobs { get; set; }
        // nanti tambahkan User, Application, dll
    }
}
