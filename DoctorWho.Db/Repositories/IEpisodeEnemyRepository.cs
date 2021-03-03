namespace DoctorWho
{
    public interface IEpisodeEnemyRepository
    {
        void AddEnemyToEpisode(int episodeId, int enemyId);
    }
}