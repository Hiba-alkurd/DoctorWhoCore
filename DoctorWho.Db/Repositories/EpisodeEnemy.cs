using System;
using System.Collections.Generic;
using System.Text;
using DoctorWho.Db;

namespace DoctorWho
{
    public class EpisodeEnemy
    {
        public int EpisodeEnemyId { get; set; }
        public int EpisodeId { get; set; }
        public Episode Episode { get; set; }

        public int EnemyId { get; set; }
        public Enemy Enemy { get; set; }

        static void AddEnemyToEpisode(int episodeId, int enemyId)
        {
            using DoctorWhoCoreDbContext _context = new DoctorWhoCoreDbContext();
            var episodeEnemy = new EpisodeEnemy() { EpisodeId = episodeId, EnemyId = enemyId };
            _context.EpisodeEnemies.Add(episodeEnemy);
            _context.SaveChanges();

        }

    }
}
