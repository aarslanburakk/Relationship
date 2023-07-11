using Microsoft.EntityFrameworkCore;
using Releationship.Models;

namespace Releationship.DbConnection
{
    public class ReleationDbContext : DbContext
    {
        public ReleationDbContext(DbContextOptions<ReleationDbContext> options) : base(options)
        {
        }
        public DbSet<Player> Players { get; set; }
        public DbSet<PlayerStat> PlayerStats { get; set; }
        public DbSet<PlayerItem> PlayerItems { get; set; }
    }
}
