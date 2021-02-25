using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DoctorWho.Db;
using Microsoft.EntityFrameworkCore;

namespace DoctorWho
{
    public class Doctor
    {
        public int DoctorId { get; set; }
        public int DoctorNumber { get; set; }
        public string DoctorName { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime FirstEpisodeDate { get; set; }
        public DateTime LastEpisodeDate { get; set; }

        public List<Episode> Episodes { get; set; }



        private static DoctorWhoCoreDbContext _context = new DoctorWhoCoreDbContext();



        public static void AddDoctor(String name, int number, DateTime birsthdate, DateTime firsteps, DateTime lasteps)
        {
            using (DoctorWhoCoreDbContext _context = new DoctorWhoCoreDbContext())
            {
                var doctor = new Doctor() { DoctorName = name, DoctorNumber = number, BirthDate = birsthdate, FirstEpisodeDate = firsteps, LastEpisodeDate = lasteps };
                _context.Doctors.Add(doctor);
                _context.SaveChanges();
            }


        }

        public static void UpdateDoctor(int id, String name, int number, DateTime birsthdate, DateTime firsteps, DateTime lasteps)
        {
            using (DoctorWhoCoreDbContext _context = new DoctorWhoCoreDbContext())
            {
                var doctor = _context.Doctors.Find(id);
                doctor.DoctorName = name;
                doctor.DoctorNumber = number;
                doctor.BirthDate = birsthdate;
                doctor.FirstEpisodeDate = firsteps;
                doctor.LastEpisodeDate = lasteps;
                _context.SaveChanges();
            }
            
        }
        public static void DeleteDoctor(int id)
        {
            using (DoctorWhoCoreDbContext _context = new DoctorWhoCoreDbContext())
            {
                var doctor = _context.Doctors.Find(id);
                _context.Remove(doctor);
                _context.SaveChanges();
            }
            
        }
        public static List<Doctor> GetAllDoctors()
        {
            using (DoctorWhoCoreDbContext _context = new DoctorWhoCoreDbContext())
            {
                var doctors = _context.Doctors.FromSqlRaw("SELECT * FROM Doctors").ToList();
                return doctors;
            }
        }

    }
}
