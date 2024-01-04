using yugen_dev.Models;
using System.Collections.Generic;

namespace yugen_dev.ViewModels
{
    public class HomeViewModel
    {
        public List<Client> Clients { get; set; }

        public List<Review> Reviews { get; set; }
        public List<Dish> Dishes { get; set; }
        public HomeViewModel()
        {
            Clients = new List<Client>();
            Reviews = new List<Review>();
            Dishes = new List<Dish>();
        }
    }
}