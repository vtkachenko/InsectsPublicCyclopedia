using Microsoft.EntityFrameworkCore;

namespace InsectsPublicCyclopedia.Data
{

    public class InsectsDbContext : DbContext
    {
        public InsectsDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Insect> Insects { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=InsectsPublicCyclopediaDB.db");
        }
    }

}
