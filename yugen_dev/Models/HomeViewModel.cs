using yugen_dev.Models;
using System.Collections.Generic;

namespace yugen_dev.ViewModels
{
    public class HomeViewModel
    {
        public List<Client> Clients { get; set; }

        public List<Review> Reviews { get; set; }

        public List<Reservation> Reservations { get; set; }
        public List<Dish> Dishes { get; set; }
        public List<Menu> Menus { get; set; }

        public HomeViewModel()
        {
            Clients = new List<Client>();
            Reviews = new List<Review>();
            Reservations = new List<Reservation>();
            Dishes = new List<Dish>();
            Menus = new List<Menu>();
        }
    }
}