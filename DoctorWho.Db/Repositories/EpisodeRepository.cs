using System;
using System.Collections.Generic;
using System.Text;
using DoctorWho.Db;

namespace DoctorWho
{
    public class EpisodeRepository 
    {

        public void AddEpisode(DoctorWhoCoreDbContext _context, int series, int authorid, int doctorid, int epsNumber, string title, string type, string notes, DateTime date)
        {
            
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
        public void UpdateEpisode(int id, int series, int authorid, int doctorid, int epsNumber, string title, string type, string notes, DateTime date)
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
        public void DeleteEpisode(int id)
        {
            using DoctorWhoCoreDbContext _context = new DoctorWhoCoreDbContext();
            var eps = _context.Episodes.Find(id);
            _context.Remove(eps);
            _context.SaveChanges();
        }
    }
}
