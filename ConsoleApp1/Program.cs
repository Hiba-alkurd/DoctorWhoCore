using System;
using System.Linq;
using DoctorWho.Db;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;

namespace DoctorWho
{
    
    class Program
    {
        

        static void Main(string[] args)
        {
            DoctorWhoCoreDbContext _context = new DoctorWhoCoreDbContext();
            var results = _context.EpisodesViews.ToList();
            Console.WriteLine(results.Count);
            //    fnEnemies(2);
            //    _context.Database.EnsureCreated();
            //    Console.WriteLine(_context.Find<Author>(1).AuthorName);
            //    UpdateAuthor(1, "updated name");
            //    Console.WriteLine(_context.Find<Author>(1).AuthorName);
            Console.WriteLine("Hello World!");
        }
    }
}
