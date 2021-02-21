using System;
using System.Collections.Generic;
using System.Text;

namespace DoctorWho
{
    public class Companion
    {
        public int CompanionId { get; set; }
        public String CompanionName { get; set; }
        public String WhoPlayed { get; set; }

        public List<EpisodeCompanion> EpisodeCompanion { get; set; }

        public Companion()
        {
            EpisodeCompanion = new List<EpisodeCompanion>();
        }
    }
}
