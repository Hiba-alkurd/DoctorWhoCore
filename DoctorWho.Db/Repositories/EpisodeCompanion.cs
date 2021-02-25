using System;
using System.Collections.Generic;
using System.Text;
using DoctorWho.Db;

namespace DoctorWho
{
    public class EpisodeCompanion
    {
        public int EpisodeCompanionId { get; set; }
        public int EpisodeId { get; set; }
        public Episode Episode { get; set; }
        public int CompanionId { get; set; }
        public Companion Companion { get; set; }

        static void AddCompanionToEpisode(int episodeId, int companionId)
        {
            using DoctorWhoCoreDbContext _context = new DoctorWhoCoreDbContext();
            var episodeCompanion = new EpisodeCompanion() { EpisodeId = episodeId, CompanionId = companionId };
            _context.EpisodeCompanions.Add(episodeCompanion);
            _context.SaveChanges();
        }
    }
}
