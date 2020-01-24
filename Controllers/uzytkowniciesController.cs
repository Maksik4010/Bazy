using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication16.Data;
using WebApplication16.Models;

namespace Portal.Controllers
{
    public class uzytkowniciesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public uzytkowniciesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: uzytkownicies
        public async Task<IActionResult> Index()
        {
            return View(await _context.uzytkownicies.ToListAsync());
        }

        // GET: uzytkownicies/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var uzytkownicy = await _context.uzytkownicies
                .FirstOrDefaultAsync(m => m.id == id);
            if (uzytkownicy == null)
            {
                return NotFound();
            }

            return View(uzytkownicy);
        }

        // GET: uzytkownicies/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: uzytkownicies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,login,haslo,imie,nazwisko,ksywka,data_zalozenia,ostatnie_logowanie,ip_ostatniego_logowania,kraj,liczba_znajomych")] uzytkownicy uzytkownicy)
        {
            if (ModelState.IsValid)
            {
                uzytkownicy.data_zalozenia = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds();
                _context.Add(uzytkownicy);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(uzytkownicy);
        }

        // GET: uzytkownicies/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var uzytkownicy = await _context.uzytkownicies.FindAsync(id);
            if (uzytkownicy == null)
            {
                return NotFound();
            }
            return View(uzytkownicy);
        }

        // POST: uzytkownicies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,login,haslo,imie,nazwisko,ksywka,data_zalozenia,ostatnie_logowanie,ip_ostatniego_logowania,kraj,liczba_znajomych")] uzytkownicy uzytkownicy)
        {
            if (id != uzytkownicy.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(uzytkownicy);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!uzytkownicyExists(uzytkownicy.id))
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
            return View(uzytkownicy);
        }

        // GET: uzytkownicies/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var uzytkownicy = await _context.uzytkownicies
                .FirstOrDefaultAsync(m => m.id == id);
            if (uzytkownicy == null)
            {
                return NotFound();
            }

            return View(uzytkownicy);
        }

        // POST: uzytkownicies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var uzytkownicy = await _context.uzytkownicies.FindAsync(id);
            _context.uzytkownicies.Remove(uzytkownicy);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool uzytkownicyExists(int id)
        {
            return _context.uzytkownicies.Any(e => e.id == id);
        }
    }
}
