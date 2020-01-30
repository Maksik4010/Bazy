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
    public class wiadomoscisController : Controller
    {
        private readonly ApplicationDbContext _context;

        public wiadomoscisController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: wiadomoscis
        public async Task<IActionResult> Index(int id)
        {
            if (id == 1)
            {
                ViewBag.imie = "dipa";
                var applicationDbContext = _context.wiadomoscis.Include(w => w.uzytkownicy);
                return View();
            }
            return View();
        }

        // GET: wiadomoscis/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wiadomosci = await _context.wiadomoscis
                .Include(w => w.uzytkownicy)
                .FirstOrDefaultAsync(m => m.Id_wiadomosci == id);
            if (wiadomosci == null)
            {
                return NotFound();
            }

            return View(wiadomosci);
        }

        // GET: wiadomoscis/Create
        public IActionResult Create()
        {
            ViewData["id_uzytkownicy"] = new SelectList(_context.uzytkownicies, "Id_uzytkownicy", "Id_uzytkownicy");
            return View();
        }

        // POST: wiadomoscis/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id_wiadomosci,Id_konwersacji,id_uzytkownicy,tresc,data_utworzenia,czy_usunieta")] wiadomosci wiadomosci)
        {
            if (ModelState.IsValid)
            {
                _context.Add(wiadomosci);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["id_uzytkownicy"] = new SelectList(_context.uzytkownicies, "Id_uzytkownicy", "Id_uzytkownicy", wiadomosci.id_uzytkownicy);
            return View(wiadomosci);
        }

        // GET: wiadomoscis/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wiadomosci = await _context.wiadomoscis.FindAsync(id);
            if (wiadomosci == null)
            {
                return NotFound();
            }
            ViewData["id_uzytkownicy"] = new SelectList(_context.uzytkownicies, "Id_uzytkownicy", "Id_uzytkownicy", wiadomosci.id_uzytkownicy);
            return View(wiadomosci);
        }

        // POST: wiadomoscis/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id_wiadomosci,Id_konwersacji,id_uzytkownicy,tresc,data_utworzenia,czy_usunieta")] wiadomosci wiadomosci)
        {
            if (id != wiadomosci.Id_wiadomosci)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(wiadomosci);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!wiadomosciExists(wiadomosci.Id_wiadomosci))
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
            ViewData["id_uzytkownicy"] = new SelectList(_context.uzytkownicies, "Id_uzytkownicy", "Id_uzytkownicy", wiadomosci.id_uzytkownicy);
            return View(wiadomosci);
        }

        // GET: wiadomoscis/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wiadomosci = await _context.wiadomoscis
                .Include(w => w.uzytkownicy)
                .FirstOrDefaultAsync(m => m.Id_wiadomosci == id);
            if (wiadomosci == null)
            {
                return NotFound();
            }

            return View(wiadomosci);
        }

        // POST: wiadomoscis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var wiadomosci = await _context.wiadomoscis.FindAsync(id);
            _context.wiadomoscis.Remove(wiadomosci);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool wiadomosciExists(int id)
        {
            return _context.wiadomoscis.Any(e => e.Id_wiadomosci == id);
        }
    }
}
