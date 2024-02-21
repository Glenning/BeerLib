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
    public class BeersRepositoryTests
    {
        private BeersRepository _beerRepo;

        [TestInitialize]
        public void Init()
        {
            _beerRepo.AddBeer(new Beer() { Id = 1, Name = "Beer1", Abv = 5 });
            _beerRepo.AddBeer(new Beer() { Id = 2, Name = "Beer2", Abv = 2 });
            _beerRepo.AddBeer(new Beer() { Id = 3, Name = "Beer3", Abv = 8 });
        }

        [TestMethod()]
        public void GetBeersTest()
        {
            BeersRepository repository = new();
            var beers = repository.GetBeers();
            Assert.AreEqual(3, beers.Count);
        }
    }
}