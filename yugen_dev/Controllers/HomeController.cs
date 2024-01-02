using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using yugen_dev.Models;
using yugen_dev.Data;
using Microsoft.EntityFrameworkCore;

namespace yugen_dev.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly YugenContext _context;
        public HomeController(ILogger<HomeController> logger, YugenContext context)
        {
            _logger = logger;
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var dishes = await _context.Dishes.ToListAsync();
            return View(dishes);
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
