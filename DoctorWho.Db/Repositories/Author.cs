using System;
using System.Collections.Generic;
using System.Text;
using DoctorWho.Db;
using Microsoft.EntityFrameworkCore;

namespace DoctorWho
{
    public class Author
    {
        public int AuthorId { get; set; }
        public String AuthorName { get; set; }

        public List<Episode> Episodes { get; set; }

        static void AddAuthor(string name)
        {
            using DoctorWhoCoreDbContext _context = new DoctorWhoCoreDbContext();
            var author = new Author() { AuthorName = name };
            _context.Authors.Add(author);
            _context.SaveChanges();
        }

        static void UpdateAuthor(int id, string name)
        {
            using DoctorWhoCoreDbContext _context = new DoctorWhoCoreDbContext();
            var author = _context.Authors.Find(id);
            author.AuthorName = name;
            _context.SaveChanges();


        }

        static void DeleteAuthor(int id)
         {
            using DoctorWhoCoreDbContext _context = new DoctorWhoCoreDbContext();
            var author = _context.Authors.Find(id);
            _context.Remove(author);
            _context.SaveChanges();

        }
    }
}
