using DoctorWho.Db;

namespace DoctorWho
{
    public interface IEpisodeCompanionRepository
    {
        void AddCompanionToEpisode(DoctorWhoCoreDbContext _context, int episodeId, int companionId);
    }
}