using System;
using System.Collections.Generic;
using System.Text;

namespace DoctorWho
{
    public class Episode
    {

        public Episode()
        {
            EpisodeCompanion = new List<EpisodeCompanion>();
            EpisodeEnemy = new List<EpisodeEnemy>();
        }

        public int EpisodeId { get; set; }
        public int SeriesNumber { get; set; }
        public int EpisodeNumber { get; set; }
        public String EpisodeType { get; set; }
        public String Title { get; set; }
        public DateTime EpisodeDate { get; set; }
        public String Notes { get; set; }

        public int AuthorId { get; set; }
        public Author author { get; set; }
        public int DoctorId { get; set; }
        public Doctor doctor { get; set; }

        public List<EpisodeCompanion> EpisodeCompanion { get; set; }
        public List<EpisodeEnemy> EpisodeEnemy { get; set; }
    }
}
