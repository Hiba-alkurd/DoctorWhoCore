using System;
using System.Collections.Generic;
using System.Text;
using DoctorWho.Db;
using Microsoft.EntityFrameworkCore;

namespace DoctorWho
{
    public class AuthorRepository : IAuthorRepository
    {
        public void AddAuthor(string name, DoctorWhoCoreDbContext _context)
        {
            var author = new Author() { AuthorName = name };
            _context.Authors.Add(author);
            _context.SaveChanges();
        }

        public void DeleteAuthor(int id, DoctorWhoCoreDbContext _context)
        {
            var author = _context.Authors.Find(id);
            _context.Remove(author);
            _context.SaveChanges();

        }

        public void UpdateAuthor(int id, string name, DoctorWhoCoreDbContext _context)
        {
            var author = _context.Authors.Find(id);
            author.AuthorName = name;
            _context.SaveChanges();


        }
    }
}
