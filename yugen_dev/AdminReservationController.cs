using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using yugen_dev.Data;
using yugen_dev.Models;

namespace yugen_dev
{
    public class AdminReservationController : Controller
    {
        private readonly YugenContext _context;

        public AdminReservationController(YugenContext context)
        {
            _context = context;
        }

        // GET: AdminReservation
        public async Task<IActionResult> Index()
        {
            return View(await _context.Reservations.ToListAsync());
        }

        // GET: AdminReservation/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservation = await _context.Reservations
                .FirstOrDefaultAsync(m => m.Id == id);
            if (reservation == null)
            {
                return NotFound();

            }

            return View(reservation);
        }

        // GET: AdminReservation/Create
        public IActionResult Create()
        {
            List<Client> ClientList = _context.Clients?.ToList() ?? new List<Client>();
            ViewBag.Clients = new SelectList(ClientList, "Id", "LastName");
            // ViewData["Client.Id"] = new SelectList(_context.Clients, "Id", "FirstName", "LastName");
            return View();
        }

        // POST: AdminReservation/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ReservationAdminViewModel reservationAdminViewModel)
        {
            if (ModelState.IsValid)
            {
                var client = new Client() {
                    LastName = reservationAdminViewModel.ClientName ?? string.Empty,
                    FirstName = string.Empty,
                    IdentityUserId = string.Empty
                };
                _context.Add(client);
                var reservation = new Reservation(){
                    NumberPeople = reservationAdminViewModel.NumberPeople,
                    DateReservation = reservationAdminViewModel.DateReservation,
                    TimeReservation = reservationAdminViewModel.TimeReservation,
                    Message = reservationAdminViewModel.Message,
                    Client = client
                };
                _context.Add(reservation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(reservationAdminViewModel);
        }

        // GET: AdminReservation/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservation = await _context.Reservations.FindAsync(id);
            if (reservation == null)
            {
                return NotFound();
            }
            return View(reservation);
        }


        // POST: AdminReservation/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NumberPeople,DateReservation,TimeReservation,Message")] Reservation reservation)
        {
            if (id != reservation.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(reservation);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReservationExists(reservation.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(reservation);
        }

        // GET: AdminReservation/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservation = await _context.Reservations
                .FirstOrDefaultAsync(m => m.Id == id);
            if (reservation == null)
            {
                return NotFound();
            }

            return View(reservation);
        }

        // POST: AdminReservation/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var reservation = await _context.Reservations.FindAsync(id);
            if (reservation != null)
            {
                _context.Reservations.Remove(reservation);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReservationExists(int id)
        {
            return _context.Reservations.Any(e => e.Id == id);
        }
    }
}
