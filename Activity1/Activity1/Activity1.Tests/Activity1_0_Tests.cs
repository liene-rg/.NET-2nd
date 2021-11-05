using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharp.Activity.Profile;

namespace Activity1.Tests
{
    [TestClass]
    public class ComputeAgeTests
    {
        [TestMethod]
        public void TestAgeEugene()
        {
            var eugene = new PlayerProfile("Eugene", PlayerProfile.MALE, new DateTime(1993, 12, 13));

            Assert.AreEqual(27, eugene.ComputeAge());
        }

        [TestMethod]
        public void TestAgeAngela()
        {
            var eugene = new PlayerProfile("Angela", PlayerProfile.FEMALE, new DateTime(1960, 12, 13));

            Assert.AreEqual(60, eugene.ComputeAge());
        }


        [TestMethod]
        public void TestAgeDwight()
        {
            var eugene = new PlayerProfile("Dwight", PlayerProfile.MALE, new DateTime(1990, 12, 15));

            Assert.AreEqual(30, eugene.ComputeAge());
        }

        [TestMethod]
        public void TestAgeTaylor()
        {
            var eugene = new PlayerProfile("Taylor", PlayerProfile.MALE, new DateTime(1991, 07, 02));

            Assert.AreEqual(30, eugene.ComputeAge());
        }

        [TestMethod]
        public void TestAgeJohn()
        {
            var john = new PlayerProfile("John", PlayerProfile.FEMALE, new DateTime(1993, 2, 1));

            Assert.AreEqual(28, john.ComputeAge());
        }

        [TestMethod]
        public void TestAgeTony()
        {
            var tony = new PlayerProfile("Tony", PlayerProfile.MALE, new DateTime(1994, 7, 30));

            Assert.AreEqual(27, tony.ComputeAge());
        }

        [TestMethod]
        public void TestAgeZero()
        {
            var now = new PlayerProfile("The Zero", PlayerProfile.MALE, DateTime.Now);

            Assert.AreEqual(0, now.ComputeAge());
        }

        [TestMethod]
        public void TestAgeNadja()
        {
            var nadja = new PlayerProfile("Nadja", PlayerProfile.FEMALE, new DateTime(1994, 7, 22));

            Assert.AreEqual(27, nadja.ComputeAge());
        }

        [TestMethod]
        public void TestAgeBob()
        {
            var bob = new PlayerProfile("Bob", PlayerProfile.MALE, new DateTime(1994, 3, 1));

            Assert.AreEqual(27, bob.ComputeAge());
        }

        [TestMethod]
        public void TestAgeChris()
        {
            var chris = new PlayerProfile("Chris", PlayerProfile.MALE, new DateTime(1994, 3, 5));

            Assert.AreEqual(27, chris.ComputeAge());
        }
    }
}
