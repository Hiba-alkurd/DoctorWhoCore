using System;
using System.Collections.Generic;
using System.Text;
using DoctorWho.Db;

namespace DoctorWho
{
    public class CompanionRepository : ICompanionRepository
    {

        public void AddCompanion(string name, string actor, DoctorWhoCoreDbContext _context)
        {
            var companion = new Companion() { CompanionName = name, WhoPlayed = actor };
            _context.Companions.Add(companion);
            _context.SaveChanges();

        }
        public void UpdateCompanion(int id, string name, string actor, DoctorWhoCoreDbContext _context)
        {
            var companion = _context.Companions.Find(id);
            companion.WhoPlayed = actor;
            companion.CompanionName = name;
            _context.SaveChanges();
        }
        public void DeleteCompanion(int id, DoctorWhoCoreDbContext _context)
        {
            var companion = _context.Companions.Find(id);
            _context.Remove(companion);
            _context.SaveChanges();

        }
        public Companion GetCompanionById(int id, DoctorWhoCoreDbContext _context)
        {
            var companion = _context.Companions.Find(id);
            return companion;

        }
    }
}
