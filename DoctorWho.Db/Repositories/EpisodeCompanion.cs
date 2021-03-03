using System;
using System.Collections.Generic;
using System.Text;
using DoctorWho.Db;

namespace DoctorWho
{
    public class EpisodeCompanionRepository : IEpisodeCompanionRepository
    {

        public void AddCompanionToEpisode(DoctorWhoCoreDbContext _context, int episodeId, int companionId)
        {
            var episodeCompanion = new EpisodeCompanion() { EpisodeId = episodeId, CompanionId = companionId };
            _context.EpisodeCompanions.Add(episodeCompanion);
            _context.SaveChanges();
        }
    }
}
