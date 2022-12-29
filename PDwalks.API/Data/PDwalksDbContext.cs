using Microsoft.EntityFrameworkCore;
using PDwalks.API.Domain;

namespace PDwalks.API.Data
{
    public class PDwalksDbContext : DbContext
    {
        public PDwalksDbContext(DbContextOptions<PDwalksDbContext> options) : base(options)
        {

        }
        //create the properties
        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }
        public DbSet<WalkDifficulty> WalkDifficulty { get; set; }
    }
}
