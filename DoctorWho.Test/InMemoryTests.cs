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
        DoctorWhoCoreDbContext initInMemoryDatabase(string name)
        {
            var builder = new DbContextOptionsBuilder();
            builder.UseInMemoryDatabase(name);
            return new DoctorWhoCoreDbContext(builder.Options);
        }

        [TestMethod]
        public void TestCompanionInsert()
        {
            //Arrange
            var context = initInMemoryDatabase("insert");
            int count = context.Companions.Count<Companion>();
            var companion = new Companion() { CompanionName = "name", WhoPlayed = "actor" };

            //Act
            context.Companions.Add(companion);

            //Assert
            Assert.AreEqual(EntityState.Added, context.Entry(companion).State);
            context.SaveChanges();
        }

        [TestMethod]
        public void TestCompanionInsertMethod()
        {
            //Arrange
            var context = initInMemoryDatabase("insert");
            int count = context.Companions.Count<Companion>();
            ICompanionRepository companion = new CompanionRepository();

            //Act
            companion.AddCompanion("name", "actor", context);

            //Assert
            Assert.AreEqual(count + 1, context.Companions.Count<Companion>());
        }

        [TestMethod]
        public void TestCompanionDelete()
        {
            //Arrange
            var context = initInMemoryDatabase("delete");
            int count = context.Companions.Count<Companion>();
            var companion = new Companion() { CompanionName = "name", WhoPlayed = "actor" };
            context.Companions.Add(companion);
            context.SaveChanges();

            //Act
            context.Companions.Remove(companion);

            //Assert
            Assert.AreEqual(EntityState.Deleted, context.Entry(companion).State);
        }

        [TestMethod]
        public void TestCompanionUpdate()
        {
            //Arrange
            var context = initInMemoryDatabase("update");
            int count = context.Companions.Count<Companion>();
            var companion = new Companion() { CompanionName = "name", WhoPlayed = "actor" };
            context.Companions.Add(companion);
            context.SaveChanges();

            //Act
            companion.CompanionName = "updated";

            //Assert
            Assert.AreEqual(EntityState.Modified, context.Entry(companion).State);

        }

        
        


    }
}
