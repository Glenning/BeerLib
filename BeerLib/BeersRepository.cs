using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerLib
{
    public class BeersRepository
    {
        private int _nextId = 4;
        private List<Beer> _beers = new()
        {
            new Beer { Id = 1, Name = "Big Beer", Abv = 8},
            new Beer { Id = 2, Name = "Light Beer", Abv = 2},
            new Beer { Id = 3, Name = "Standard Beer", Abv = 4}
        };

        public List<Beer> GetBeers()
        {
            return new List<Beer>( _beers );
        }

        public Beer AddBeer( Beer beer )
        {
            beer.Id = _nextId++;
            _beers.Add( beer );
            return beer;
        }

        public Beer? DeleteBeer(int id)
        {
            Beer? beer = _beers.Find(b => b.Id == id);
            if (beer !=null)
            {
                _beers.Remove(beer);
            }
            return beer;
        }

        //public Beer? UpdateBeer(int id, Beer beerData) 
        //{
        //    beerData.ValidBeer();
        //    Beer? beerToUpdate = _beers.Find(b => b.Id == beerData.Id);
        //    if (beerToUpdate != null)
        //    {
        //        beerToUpdate.Name = beerData.Name;
        //        beerToUpdate.Abv = beerData.Abv;
        //    }
        //    return beerToUpdate;
        //}

        public Beer? UpdateBeer(int Id, Beer beerData)
        {
            Beer? beerToUpdate = _beers.Find(b => b.Id == beerData.Id);
            if (beerToUpdate != null)
            {
                {
                    beerToUpdate.Id = beerData.Id;
                    beerToUpdate.Name = beerData.Name;
                    beerToUpdate.Abv = beerData.Abv;
                    _beers.Add(beerToUpdate);
                }
            }
            return beerToUpdate;
        }

        public Beer? GetById(int id)
        {
            return _beers.Find(beer => beer.Id == id);
        }
    }
}
