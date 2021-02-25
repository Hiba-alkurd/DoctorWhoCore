using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace DoctorWho.Db
{
    public class FuncClasses
    {

    }
    public class EpisodesView
    {
        public int EpisodeId { get; private set; }
        public string Title { get; private set; }
        public string AuthorName { get; private set; }
        public string DoctorName { get; private set; }
        public string CompanionName { get; private set; }
        public string EnemyName { get; private set; }

    }

    public class fnCompanionsClass
    {
        public String CompanionName { get; set; }
        static List<fnCompanionsClass> fnCompanions(int id)
        {
            using (var _context = new DoctorWhoCoreDbContext())
            {
                var companinos = _context.CompanionsNames
                        .FromSqlRaw("Select * From fnCompanions({0})", id)
                        .ToList();


                return companinos;
            }

        }
    }
    public class fnEnemiesClass
    {
        public String EnemyName { get; set; }
        public static List<fnEnemiesClass> fnEnemies(int id)
        {
                using (var _context = new DoctorWhoCoreDbContext())
                {
                    var enemies = _context.EnemiesNames
                        .FromSqlRaw("Select * From fnEnemies({0})", id)
                        .ToList();

                    return enemies;
                }

        }
    }
    public class spSummariseEpisodesCompanions
    {
        public int CompanionId { get; set; }
        public String CompanionName { get; set; }
    }
    public class spSummariseEpisodesEnemies
    {
        public int EnemyId { get; set; }
        public String EnemyName { get; set; }
        //static void ProcAsync()
        //{


        //    using (var _context = new DoctorWhoCoreDbContext())
        //    {
        //        var cmd = _context.Database.GetDbConnection().CreateCommand();
        //        cmd.CommandText = "[dbo].[spSummariseEpisodes]";

        //        try
        //        {

        //            _context.Database.OpenConnection();
        //            // Run the sproc
        //            var reader = cmd.ExecuteReader();

        //            // Read Blogs from the first result set
        //            var blogs = ((IObjectContextAdapter)_context)
        //                .ObjectContext
        //                .Translate<spSummariseEpisodesCompanions>(reader, "CompanionsEpisodeSummary", MergeOption.AppendOnly);


        //            foreach (var item in blogs)
        //            {
        //                Console.WriteLine(item.CompanionName);
        //            }

        //            // Move to second result set and read Posts
        //            reader.NextResult();
        //            var posts = ((IObjectContextAdapter)_context)
        //                .ObjectContext
        //                .Translate<spSummariseEpisodesEnemies>(reader, "EnemiesEpisodeSummary", MergeOption.AppendOnly);


        //            foreach (var item in posts)
        //            {
        //                Console.WriteLine(item.EnemyName);
        //            }
        //        }
        //        finally
        //        {
        //            _context.Database.CloseConnection();
        //        }

        //    }

        //}
    }
    
}
