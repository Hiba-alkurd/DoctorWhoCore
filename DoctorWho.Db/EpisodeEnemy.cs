﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DoctorWho
{
    public class EpisodeEnemy
    {
        public int EpisodeEnemyId { get; set; }
        public int EpisodeId { get; set; }
        public Episode Episode { get; set; }

        public int EnemyId { get; set; }
        public Enemy Enemy { get; set; }

    }
}
