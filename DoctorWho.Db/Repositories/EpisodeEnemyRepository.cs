using System;
using System.Collections.Generic;
using System.Text;
using DoctorWho.Db;

namespace DoctorWho
{
    public class EpisodeEnemyRepository : IEpisodeEnemyRepository
    {
        public void AddEnemyToEpisode(int episodeId, int enemyId)
        {
            using DoctorWhoCoreDbContext _context = new DoctorWhoCoreDbContext();
            var episodeEnemy = new EpisodeEnemy() { EpisodeId = episodeId, EnemyId = enemyId };
            _context.EpisodeEnemies.Add(episodeEnemy);
            _context.SaveChanges();

        }

    }
}
