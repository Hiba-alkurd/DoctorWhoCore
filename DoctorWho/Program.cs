using System;
using DoctorWho.Db;

namespace DoctorWho
{
    
    class Program
    {
        private static DoctorWhoCoreDbContext _context = new DoctorWhoCoreDbContext();

        //create
        static void AddAuthor(string name)
        {
            var author = new Author() { AuthorName = name};
            _context.Authors.Add(author);
            _context.SaveChanges();
        }
        //update
        static void UpdateAuthor(int id, string name)
        {
            var author = _context.Authors.Find(id);
            author.AuthorName = name;
            _context.SaveChanges();
        }


        //Delete
        static void DeleteAuthor(int id)
        {
            var author = _context.Authors.Find(id);
            _context.Remove(author);
            _context.SaveChanges();
        }

        static void AddDoctor(String name, int number, DateTime birsthdate, DateTime firsteps, DateTime lasteps)
        {
            var doctor = new Doctor() { DoctorName = name, DoctorNumber = number, BirthDate = birsthdate, FirstEpisodeDate = firsteps, LastEpisodeDate = lasteps };
            _context.Doctors.Add(doctor);
            _context.SaveChanges();

        }

        static void UpdateDoctor(int id, String name, int number, DateTime birsthdate, DateTime firsteps, DateTime lasteps)
        {
            var doctor = _context.Doctors.Find(id);
            doctor.DoctorName = name;
            doctor.DoctorNumber = number;
            doctor.BirthDate = birsthdate;
            doctor.FirstEpisodeDate = firsteps;
            doctor.LastEpisodeDate = lasteps; 
            _context.SaveChanges();
        }
        static void DeleteDoctor(int id)
        {
            var doctor = _context.Doctors.Find(id);
            _context.Remove(doctor);
            _context.SaveChanges();
        }

        static void AddCompanion(string name, string actor)
        {
            var companion = new Companion() { CompanionName = name, WhoPlayed = actor };
            _context.Companions.Add(companion);
            _context.SaveChanges();
        }
        static void UpdateCompanion(int id, string name, string actor)
        {
            var companion = _context.Companions.Find(id);
            companion.WhoPlayed = actor;
            companion.CompanionName = name;
            _context.SaveChanges();
        }
        static void DeleteCompanion(int id)
        {
            var companion = _context.Companions.Find(id);
            _context.Remove(companion);
            _context.SaveChanges();
        }
        static void AddEnemy(string name, string desc)
        {
            var enemy = new Enemy() { EnemyName = name, Description = desc };
            _context.Enemies.Add(enemy);
            _context.SaveChanges();
        }
        static void UpdateEnemy(int id, string name, string desc)
        {
            var enemy = _context.Enemies.Find(id);
            enemy.EnemyName = name;
            enemy.Description = desc;
            _context.SaveChanges();
        }
        static void DeleteEnemy(int id)
        {
            var enemy = _context.Enemies.Find(id);
            _context.Remove(enemy);
            _context.SaveChanges();
        }
        static void AddEpisode(int series, int authorid, int doctorid, int epsNumber, string title, string type, string notes, DateTime date)
        {
            var episode = new Episode() {
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
        static void UpdateEpisode(int id, int series, int authorid, int doctorid, int epsNumber, string title, string type, string notes, DateTime date)
        {
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
        static void DeleteEpisode(int id)
        {
            var eps = _context.Episodes.Find(id);
            _context.Remove(eps);
            _context.SaveChanges();
        }

        static void Main(string[] args)
        {
            Console.WriteLine(_context.Find<Author>(1).AuthorName);
            UpdateAuthor(1, "updated name");
            Console.WriteLine(_context.Find<Author>(1).AuthorName);
            Console.WriteLine("Hello World!");
        }
    }
}
