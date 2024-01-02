using yugen_dev.Models;
using System.Collections.Generic;

namespace yugen_dev.ViewModels
{
    public class HomeViewModel
    {
        public List<Client> Clients { get; set; }

        public HomeViewModel()
        {
            Clients = new List<Client>();
        }
    }
}