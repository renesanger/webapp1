using System.Collections.Generic;
using WebApplication1.Entities;
using System.Linq;

namespace WebApplication1.Services
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
        Restaurant Get(int id);
    }
    public class InMemoryRestaurantData : IRestaurantData
    {
        public InMemoryRestaurantData()
        {
            _restaurants = new List<Restaurant>
            {
            new Restaurant {  Id = 1, Name = "mcdonalds"},
            new Restaurant {  Id = 2, Name = "burger king"},
            new Restaurant { Id = 3, Name = "wendys" }
            };
        }

        public Restaurant Get(int id)
        {
            return _restaurants.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return _restaurants;
        }

        List<Restaurant> _restaurants;
    }

}
