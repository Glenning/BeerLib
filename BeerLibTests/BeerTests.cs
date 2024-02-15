using Microsoft.VisualStudio.TestTools.UnitTesting;
using BeerLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerLib.Tests
{
    [TestClass()]
    public class BeerTests
    {
        [TestMethod()]
        public void ToStringTest()
        {

        }

        [TestMethod()]
        public void ValidNameTest()
        {
            Beer nullBeer = new()
            {
                Id = 1,
                Name = null,
                Abv = 7
            };
            Assert.ThrowsException<ArgumentNullException>(
                () => nullBeer.ValidName());

            Beer shortBeer = new()
            {
                Id = 2,
                Name = "B",
                Abv = 10
            };
            Assert.ThrowsException<ArgumentException>(
                () => shortBeer.ValidName());
        }

        [TestMethod()]
        public void ValidAbvTest()
        {
            Beer negAbvBeer = new()
            {
                Id = 3,
                Name = "AbvTest1",
                Abv = -1
            };
            Assert.ThrowsException<ArgumentOutOfRangeException>(
                () => negAbvBeer.ValidAbv());

            Beer highAbvBeer = new()
            {
                Id = 4,
                Name = "AbvTest2",
                Abv = 70
            };
            Assert.ThrowsException<ArgumentOutOfRangeException>(
                () =>  highAbvBeer.ValidAbv());
        }
    }
}