using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using yugen_dev.Models;
using yugen_dev.Data;
using Microsoft.EntityFrameworkCore;
using yugen_dev.ViewModels;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;


namespace yugen_dev.Controllers
{
    public class HomeController : Controller
    {
        private readonly YugenContext _context;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, YugenContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            // var dishes = await _context.Dishes.ToListAsync();
            var viewModel = new HomeViewModel
            {
                Dishes = await _context.Dishes.ToListAsync(),
                Clients = await _context.Clients.ToListAsync(),
                Reviews = await _context.Reviews.Include(r => r.Client).ToListAsync(),
                Menus = await _context.Menus
                            .Include(m => m.MenusDishes)
                            .ThenInclude(md => md.Dish)
                            .ToListAsync(),
                Reservations = await _context.Reservations.ToListAsync()
            };

            return View(viewModel);
        }


        public IActionResult Privacy()
        {
            return View();
        }

        public async Task<IActionResult> Booking()
        {
            string clientFirstName = "Visiteur non connecté"; // Default name

            if (User.Identity.IsAuthenticated)
            {
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                var client = await _context.Clients.SingleOrDefaultAsync(c => c.IdentityUserId == userId);

                if (client != null)
                {
                    clientFirstName = client.FirstName;
                }
            }
            else
            {
                return RedirectToPage("/Account/Login", new { area = "Identity" });
            }

            ViewData["ClientFirstName"] = clientFirstName;

            return View();
            }

            [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
            public IActionResult Error()
            {
                return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [Authorize]
        public class SecretController : Controller
        {
        public IActionResult Secret()
        {
        return View();
        }
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NumberPeople,DateReservation,TimeReservation,Message,Client")] Reservation Reservation)
        {

            if (ModelState.IsValid)
                {
                    // var client = await _context.Clients.FindAsync(1);

                    var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                    var client = await _context.Clients.SingleOrDefaultAsync(c => c.IdentityUserId == userId);


                    if (client != null)
                        {
                        Reservation.Client = client;

                        _context.Add(Reservation);
                        await _context.SaveChangesAsync();
                        TempData["SuccessMessage"] = "La réservation a bien été enregistrée!";
                        return RedirectToAction(nameof(Index));
                        }
                    else
                    {
                         return BadRequest("Client not found");
                    }
                }
                else {
                    System.Console.WriteLine("model not valid!");
                }
            return View(Reservation);
        }

    }
}
