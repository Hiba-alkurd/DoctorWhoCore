using System.Collections.Generic;
using DoctorWho.Db;

namespace DoctorWho
{
    public interface ICompanionRepository
    {

        void AddCompanion(string name, string actor, DoctorWhoCoreDbContext _context);
        void DeleteCompanion(int id, DoctorWhoCoreDbContext _context);
        Companion GetCompanionById(int id, DoctorWhoCoreDbContext _context);
        void UpdateCompanion(int id, string name, string actor, DoctorWhoCoreDbContext _context);
    }
}