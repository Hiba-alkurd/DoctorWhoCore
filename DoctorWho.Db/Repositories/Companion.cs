using System;
using System.Collections.Generic;
using System.Text;
using DoctorWho.Db;

namespace DoctorWho
{
    public class Companion
    {
        public int CompanionId { get; set; }
        public String CompanionName { get; set; }
        public String WhoPlayed { get; set; }

        public List<EpisodeCompanion> EpisodeCompanion { get; set; }

        public Companion()
        {
            EpisodeCompanion = new List<EpisodeCompanion>();
        }


        public static void AddCompanion(string name, string actor)
        {
            using DoctorWhoCoreDbContext _context = new DoctorWhoCoreDbContext();
            var companion = new Companion() { CompanionName = name, WhoPlayed = actor };
            _context.Companions.Add(companion);
            _context.SaveChanges();

        }
        public static void UpdateCompanion(int id, string name, string actor)
        {
            using DoctorWhoCoreDbContext _context = new DoctorWhoCoreDbContext();
            var companion = _context.Companions.Find(id);
            companion.WhoPlayed = actor;
            companion.CompanionName = name;
            _context.SaveChanges();
        }
        public static void DeleteCompanion(int id)
        {
            using DoctorWhoCoreDbContext _context = new DoctorWhoCoreDbContext();
            var companion = _context.Companions.Find(id);
            _context.Remove(companion);
            _context.SaveChanges();

        }
        public static Companion GetCompanionById(int id)
        {
            using DoctorWhoCoreDbContext _context = new DoctorWhoCoreDbContext();
            var companion = _context.Companions.Find(id);
            return companion;

        }
    }
}
