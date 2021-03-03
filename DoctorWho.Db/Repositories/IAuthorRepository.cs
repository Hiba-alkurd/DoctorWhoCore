using DoctorWho.Db;

namespace DoctorWho
{
    public interface IAuthorRepository
    {

        public void AddAuthor(string name, DoctorWhoCoreDbContext _context);

        public void DeleteAuthor(int id, DoctorWhoCoreDbContext _context);

        public void UpdateAuthor(int id, string name, DoctorWhoCoreDbContext _context);
    }
}