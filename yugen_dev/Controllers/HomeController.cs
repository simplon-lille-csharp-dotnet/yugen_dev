using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using yugen_dev.Models;
using yugen_dev.Data;
using Microsoft.EntityFrameworkCore;


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
        var clients = await _context.Clients.ToListAsync();
        return View(clients);
         
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
