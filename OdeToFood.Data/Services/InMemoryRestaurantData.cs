using OdeToFood.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OdeToFood.Data.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> restaurants;

        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant { ID = 1, RestaurantName = "Zaitoon" , Cuisine = CuisineType.Arabic },
                new Restaurant { ID = 2, RestaurantName = "24th Main", Cuisine = CuisineType.Indian },
                new Restaurant { ID = 3, RestaurantName = "Dominos", Cuisine = CuisineType.Italian },

            };
        }

        public IEnumerable<Restaurant> GetALL()
        {
            return restaurants.OrderBy(r => r.RestaurantName);
        }
    }
}
