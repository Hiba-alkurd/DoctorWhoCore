using System;
using System.Collections.Generic;
using System.Text;
using DoctorWho.Db;

namespace DoctorWho
{
    public class Enemy
    {
        public int EnemyId { get; set; }
        public String EnemyName { get; set; }
        public String Description { get; set; }

        public List<EpisodeEnemy> EpisodeEnemy { get; set; }

        public Enemy()
        {
            EpisodeEnemy = new List<EpisodeEnemy>();
        }


        static void AddEnemy(string name, string desc)
        {
            using DoctorWhoCoreDbContext _context = new DoctorWhoCoreDbContext();
            var enemy = new Enemy() { EnemyName = name, Description = desc };
            _context.Enemies.Add(enemy);
            _context.SaveChanges();
        }
        static void UpdateEnemy(int id, string name, string desc)
        {
            using DoctorWhoCoreDbContext _context = new DoctorWhoCoreDbContext();
            var enemy = _context.Enemies.Find(id);
            enemy.EnemyName = name;
            enemy.Description = desc;
            _context.SaveChanges();
        }
        static void DeleteEnemy(int id)
        {
            using DoctorWhoCoreDbContext _context = new DoctorWhoCoreDbContext();
            var enemy = _context.Enemies.Find(id);
            _context.Remove(enemy);
            _context.SaveChanges();
        }
        
        static Enemy GetEnemyById(int id)
        {
            using DoctorWhoCoreDbContext _context = new DoctorWhoCoreDbContext();
            var enemy = _context.Enemies.Find(id);
            return enemy;

        }


    }
}
