using System;
using System.Collections.Generic;
using System.Text;

namespace DoctorWho
{
    public class Enemy
    {
        public int EnemyId { get; set; }
        public String EnemyName { get; set; }
        public String Description { get; set; }

        public List<EpisodeEnemy> EpisodeEnemy { get; set; }

        public Enemy(List<EpisodeEnemy> episodeEnemy)
        {
            EpisodeEnemy = new List<EpisodeEnemy>();
        }
    }
}
