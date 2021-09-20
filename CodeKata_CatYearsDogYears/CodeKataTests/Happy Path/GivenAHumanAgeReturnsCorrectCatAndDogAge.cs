using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CodeKata_CatYearsDogYears;

namespace CodeKataTests.Happy_Path
{
    class GivenAHumanAgeReturnsCorrectCatAndDogAge
    {
        [Test]
        public void One()
        {
            Assert.AreEqual(new int[] { 1, 15, 15 }, Program.GivenHumanAgeReturnCatDogAge(1));
        }

        [Test]
        public void Two()
        {
            Assert.AreEqual(new int[] { 2, 24, 24 }, Program.GivenHumanAgeReturnCatDogAge(2));
        }

        [Test]
        public void Ten()
        {
            Assert.AreEqual(new int[] { 10, 56, 64 }, Program.GivenHumanAgeReturnCatDogAge(10));
        }

        [Test]
        public void Fifteen()
        {
            Assert.AreEqual(new int[] { 15, 76, 89 }, Program.GivenHumanAgeReturnCatDogAge(15));
        }

        [Test]
        public void Negative()
        {
            Assert.AreEqual(new int[] { 0, 0, 0 }, Program.GivenHumanAgeReturnCatDogAge(-10));
        }

        [Test]
        public void Zero()
        {
            Assert.AreEqual(new int[] { 0, 0, 0 }, Program.GivenHumanAgeReturnCatDogAge(0));
        }
    }
}
