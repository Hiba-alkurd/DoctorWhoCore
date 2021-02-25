using System;
using System.Collections.Generic;
using System.Text;
using DoctorWho.Db;

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



        public static void AddEpisode(int series, int authorid, int doctorid, int epsNumber, string title, string type, string notes, DateTime date)
        {
            using DoctorWhoCoreDbContext _context = new DoctorWhoCoreDbContext();
            var episode = new Episode()
            {
                Title = title,
                SeriesNumber = series,
                AuthorId = authorid,
                DoctorId = doctorid,
                EpisodeNumber = epsNumber,
                EpisodeType = type,
                EpisodeDate = date,
                Notes = notes,
            };
            _context.Episodes.Add(episode);
            _context.SaveChanges();

        }
        public static void UpdateEpisode(int id, int series, int authorid, int doctorid, int epsNumber, string title, string type, string notes, DateTime date)
        {
            using DoctorWhoCoreDbContext _context = new DoctorWhoCoreDbContext();
            var episode = _context.Episodes.Find(id);
            episode.Title = title;
            episode.SeriesNumber = series;
            episode.AuthorId = authorid;
            episode.DoctorId = doctorid;
            episode.EpisodeNumber = epsNumber;
            episode.EpisodeType = type;
            episode.EpisodeDate = date;
            episode.Notes = notes;
            _context.SaveChanges();
        }
        public static void DeleteEpisode(int id)
        {
            using DoctorWhoCoreDbContext _context = new DoctorWhoCoreDbContext();
            var eps = _context.Episodes.Find(id);
            _context.Remove(eps);
            _context.SaveChanges();
        }
    }
}
