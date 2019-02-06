using System.Collections.Generic;
using WebApplication1.Entities;

namespace WebApplication1.ViewModels
{
    public class HomePageViewModel
    {
        public IEnumerable<Restaurant> Restaurants { get; set; }
        public string CurrentGreeting { get; set; }
    }
}
