using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using yugen_dev.Models;
using yugen_dev.Data;
using Microsoft.EntityFrameworkCore;
using yugen_dev.ViewModels;
using System.Reflection.Metadata.Ecma335;


namespace yugen_dev.Controllers
{
    public class HomeController : Controller
    {
                private readonly YugenContext _context;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger,YugenContext context)
        {
            _logger = logger;
              _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var viewModel = new HomeViewModel
            {
                Clients = await _context.Clients.ToListAsync(),
                Reviews = await _context.Reviews.ToListAsync(),
            };

            return View(viewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
