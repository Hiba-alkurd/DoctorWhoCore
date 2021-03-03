using System;
using System.Collections.Generic;
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
        public DbSet<fnCompanionsClass> CompanionsNames { get; set; }
        public DbSet<fnEnemiesClass> EnemiesNames { get; set; }
        public DbSet<spSummariseEpisodesCompanions> CompanionsEpisodeSummary { get; set; }
        public DbSet<spSummariseEpisodesEnemies> EnemiesEpisodeSummary { get; set; }

        public DbSet<EpisodesView> EpisodesViews { get; set; }

        public DoctorWhoCoreDbContext()
        { }

        public DoctorWhoCoreDbContext(DbContextOptions options)
          : base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            if (!dbContextOptionsBuilder.IsConfigured)
            {
                dbContextOptionsBuilder.UseSqlServer("server=LAPTOP-QM0H46RJ\\SQLEXPRESS;database=DoctorWhoCore;trusted_connection=true;");
            }
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EpisodesView>().ToView("viewEpisodes");
            modelBuilder.Entity<EpisodesView>().HasNoKey();
            modelBuilder.Entity<fnCompanionsClass>().HasNoKey();
            modelBuilder.Entity<fnEnemiesClass>().HasNoKey();
            modelBuilder.Entity<spSummariseEpisodesCompanions>().HasNoKey();
            modelBuilder.Entity<spSummariseEpisodesEnemies>().HasNoKey();

            modelBuilder.Entity<Author>().HasData(
            new Author { AuthorId = 1, AuthorName = "A1" },
            new Author { AuthorId = 2, AuthorName = "A2" },
            new Author { AuthorId = 3, AuthorName = "A3" },
            new Author { AuthorId = 4, AuthorName = "A4" },
            new Author { AuthorId = 5, AuthorName = "A5" });

            modelBuilder.Entity<Doctor>().HasData(
            new Doctor { DoctorId = 1, DoctorNumber = 20, DoctorName = "D1", BirthDate = new DateTime(2016, 6, 28), FirstEpisodeDate = new DateTime(2016, 6, 28), LastEpisodeDate = new DateTime(2017, 6, 28) },
            new Doctor { DoctorId = 2, DoctorNumber = 21, DoctorName = "D2", BirthDate = new DateTime(2016, 7, 28), FirstEpisodeDate = new DateTime(2016, 6, 28), LastEpisodeDate = new DateTime(2017, 6, 28) },
            new Doctor { DoctorId = 3, DoctorNumber = 22, DoctorName = "D3", BirthDate = new DateTime(2016, 8, 28), FirstEpisodeDate = new DateTime(2016, 6, 28), LastEpisodeDate = new DateTime(2017, 6, 28) },
            new Doctor { DoctorId = 4, DoctorNumber = 23, DoctorName = "D4", BirthDate = new DateTime(2016, 9, 28), FirstEpisodeDate = new DateTime(2016, 6, 28), LastEpisodeDate = new DateTime(2017, 6, 28) },
            new Doctor { DoctorId = 5, DoctorNumber = 24, DoctorName = "D5", BirthDate = new DateTime(2016, 10, 28), FirstEpisodeDate = new DateTime(2016, 6, 28), LastEpisodeDate = new DateTime(2017, 6, 28) });

            modelBuilder.Entity<Companion>().HasData(
            new Companion { CompanionId = 1, CompanionName = "C1", WhoPlayed = "CA1" },
            new Companion { CompanionId = 2, CompanionName = "C2", WhoPlayed = "CA2" },
            new Companion { CompanionId = 3, CompanionName = "C3", WhoPlayed = "CA3" },
            new Companion { CompanionId = 4, CompanionName = "C4", WhoPlayed = "CA4" },
            new Companion { CompanionId = 5, CompanionName = "C5", WhoPlayed = "CA5" });

            modelBuilder.Entity<Enemy>().HasData(
            new Enemy { EnemyId = 1, EnemyName = "C1", Description = "L1" },
            new Enemy { EnemyId = 2, EnemyName = "C2", Description = "L2" },
            new Enemy { EnemyId = 3, EnemyName = "C3", Description = "L3" },
            new Enemy { EnemyId = 4, EnemyName = "C4", Description = "L4" },
            new Enemy { EnemyId = 5, EnemyName = "C5", Description = "L5" });

            modelBuilder.Entity<Episode>().HasData(
            new Episode
            {
                EpisodeId = 1,
                Title = "first eps",
                SeriesNumber = 1,
                AuthorId = 1,
                DoctorId = 3,
                EpisodeNumber = 1,
                EpisodeType = "action",
                EpisodeDate = new DateTime(2000, 1, 5),
                Notes = "meeh"
            },
            new Episode
            {
                EpisodeId = 2,
                Title = "second eps",
                SeriesNumber = 1,
                AuthorId = 1,
                DoctorId = 3,
                EpisodeNumber = 2,
                EpisodeType = "action",
                EpisodeDate = new DateTime(2000, 1, 6),
                Notes = "meeh"
            },
            new Episode
            {
                EpisodeId = 3,
                Title = "first eps",
                SeriesNumber = 1,
                AuthorId = 1,
                DoctorId = 3,
                EpisodeNumber = 3,
                EpisodeType = "action",
                EpisodeDate = new DateTime(2000, 1, 7),
                Notes = "meeh"
            },
            new Episode
            {
                EpisodeId = 4,
                Title = "first eps",
                SeriesNumber = 1,
                AuthorId = 2,
                DoctorId = 3,
                EpisodeNumber = 6,
                EpisodeType = "action",
                EpisodeDate = new DateTime(2000, 1, 8),
                Notes = "meeh"
            },
            new Episode
            {
                EpisodeId = 5,
                Title = "first eps",
                SeriesNumber = 1,
                AuthorId = 1,
                DoctorId = 3,
                EpisodeNumber = 5,
                EpisodeType = "action",
                EpisodeDate = new DateTime(2000, 1, 9),
                Notes = "meeh"
            });

            modelBuilder.Entity<EpisodeCompanion>().HasData(
            new EpisodeCompanion { EpisodeCompanionId = 1, CompanionId = 1, EpisodeId = 1 },
            new EpisodeCompanion { EpisodeCompanionId = 2, CompanionId = 1, EpisodeId = 2 },
            new EpisodeCompanion { EpisodeCompanionId = 3, CompanionId = 1, EpisodeId = 3 },
            new EpisodeCompanion { EpisodeCompanionId = 4, CompanionId = 3, EpisodeId = 4 },
            new EpisodeCompanion { EpisodeCompanionId = 5, CompanionId = 3, EpisodeId = 5 });

            modelBuilder.Entity<EpisodeEnemy>().HasData(
            new EpisodeEnemy { EpisodeEnemyId = 1, EnemyId = 1, EpisodeId = 1 },
            new EpisodeEnemy { EpisodeEnemyId = 2, EnemyId = 1, EpisodeId = 2 },
            new EpisodeEnemy { EpisodeEnemyId = 3, EnemyId = 1, EpisodeId = 3 },
            new EpisodeEnemy { EpisodeEnemyId = 4, EnemyId = 4, EpisodeId = 4 },
            new EpisodeEnemy { EpisodeEnemyId = 5, EnemyId = 5, EpisodeId = 4 });


        }
    }

}
