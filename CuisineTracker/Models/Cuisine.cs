using System.Collections.Generic;

namespace CuisineTracker.Models
{
    public class Cuisine
    {
        public int CuisineId { get; set; }
        public string Description { get; set; }
        public List<Restaurant> Restaurants { get; set; }
    }
}