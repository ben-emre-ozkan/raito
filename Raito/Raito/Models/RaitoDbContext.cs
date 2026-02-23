using Microsoft.EntityFrameworkCore;

namespace Raito.Models
{
    public class RaitoDbContext : DbContext
    {
        public RaitoDbContext(DbContextOptions<RaitoDbContext> options) : base(options)
        {
        }

        public DbSet<Announcement> Announcements { get; set; }
    }
}