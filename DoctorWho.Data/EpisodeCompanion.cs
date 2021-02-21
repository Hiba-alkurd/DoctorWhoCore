using System;
using System.Collections.Generic;
using System.Text;

namespace DoctorWho
{
    public class EpisodeCompanion
    {
        public int EpisodeCompanionId { get; set; }
        public int EpisodeId { get; set; }
        public Episode Episode { get; set; }
        public int CompanionId { get; set; }
        public Companion Companion { get; set; }
    }
}
