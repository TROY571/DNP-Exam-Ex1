using Microsoft.EntityFrameworkCore;
using VolumeWebService.VolumeCalculator;

namespace VolumeWebService.Persistence
{
    public class VolumeDBContext : DbContext
    {
        public DbSet<VolumeResult> VolumeResults { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = Volume.db");
        }
    }
}