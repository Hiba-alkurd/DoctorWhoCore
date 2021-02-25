using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.EntityFrameworkCore;
using DoctorWho.Db;
using System.Diagnostics;
using System.Linq;

namespace DoctorWho.Test
{
    [TestClass]
    public class InMemoryTests
    {
        [TestMethod]
        public void TestCompanionInsert()
        {
            var builder = new DbContextOptionsBuilder();
            builder.UseInMemoryDatabase("CanInsert");
            using (var context = new DoctorWhoCoreDbContext())
            {
                var companion = new Companion() { CompanionName = "name", WhoPlayed = "actor"};
                context.Companions.Add(companion);
                Assert.AreEqual(EntityState.Added, context.Entry(companion).State);

            }
        }
        [TestMethod]
        public void TestCompanionDelete()
        {
            var builder = new DbContextOptionsBuilder();
            builder.UseInMemoryDatabase("Candelete");
            using (var context = new DoctorWhoCoreDbContext())
            {
                var companion = new Companion() { CompanionName = "name", WhoPlayed = "actor" };
                context.Companions.Add(companion);
                context.SaveChanges();
                context.Companions.Remove(companion);
                Assert.AreEqual(EntityState.Deleted, context.Entry(companion).State);

            }
        }
        [TestMethod]
        public void TestCompanionUpdate()
        {
            var builder = new DbContextOptionsBuilder();
            builder.UseInMemoryDatabase("CanUpdate");
            using (var context = new DoctorWhoCoreDbContext())
            {
                var companion = new Companion() { CompanionName = "name", WhoPlayed = "actor" };
                context.Companions.Add(companion);
                context.SaveChanges();
                companion.CompanionName = "updated";
                Assert.AreEqual(EntityState.Modified, context.Entry(companion).State);

            }
        }


    }
}
