using DoctorWho.Db;

namespace DoctorWho
{
    public interface IEnemyRepository
    {
        void AddEnemy(string name, string desc, DoctorWhoCoreDbContext _context);
        void DeleteEnemy(int id, DoctorWhoCoreDbContext _context);
        Enemy GetEnemyById(int id, DoctorWhoCoreDbContext _context);
        void UpdateEnemy(int id, string name, string desc, DoctorWhoCoreDbContext _context);
    }
}