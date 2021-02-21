using Microsoft.EntityFrameworkCore;
namespace DoctorWho.Db
{
    public class DoctorWhoCoreDbContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Companion> Companions { get; set; }
        public DbSet<Enemy> Enemies { get; set; }
        public DbSet<Episode> Episodes { get; set; }
        public DbSet<EpisodeCompanion> EpisodeCompanions { get; set; }
        public DbSet<EpisodeEnemy> EpisodeEnemies { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB;database=DoctorWhoCore;trusted_connection=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }

}
