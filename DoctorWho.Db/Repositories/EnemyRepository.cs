using System;
using System.Collections.Generic;
using System.Text;
using DoctorWho.Db;

namespace DoctorWho
{
    public class EnemyRepository : IEnemyRepository
    {

        public void AddEnemy(string name, string desc, DoctorWhoCoreDbContext _context)
        {
            var enemy = new Enemy() { EnemyName = name, Description = desc };
            _context.Enemies.Add(enemy);
            _context.SaveChanges();
        }
        public void UpdateEnemy(int id, string name, string desc, DoctorWhoCoreDbContext _context)
        {
            var enemy = _context.Enemies.Find(id);
            enemy.EnemyName = name;
            enemy.Description = desc;
            _context.SaveChanges();
        }
        public void DeleteEnemy(int id, DoctorWhoCoreDbContext _context)
        {
            var enemy = _context.Enemies.Find(id);
            _context.Remove(enemy);
            _context.SaveChanges();
        }

        public Enemy GetEnemyById(int id, DoctorWhoCoreDbContext _context)
        {
            var enemy = _context.Enemies.Find(id);
            return enemy;

        }


    }
}
