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
    public class postiesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public postiesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: posties
        public async Task<IActionResult> Index()
        {
            return View(await _context.posties.ToListAsync());
        }

        // GET: posties/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var posty = await _context.posties
                .FirstOrDefaultAsync(m => m.id_posty == id);
            if (posty == null)
            {
                return NotFound();
            }

            return View(posty);
        }

        // GET: posties/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: posties/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id_posty,typ,id_zuytkownicy,tresc,data_utworzenia,liczba_like,liczba_dislike,status_komentarzy")] posty posty)
        {
            if (ModelState.IsValid)
            {
                _context.Add(posty);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(posty);
        }

        // GET: posties/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var posty = await _context.posties.FindAsync(id);
            if (posty == null)
            {
                return NotFound();
            }
            return View(posty);
        }

        // POST: posties/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id_posty,typ,id_zuytkownicy,tresc,data_utworzenia,liczba_like,liczba_dislike,status_komentarzy")] posty posty)
        {
            if (id != posty.id_posty)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(posty);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!postyExists(posty.id_posty))
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
            return View(posty);
        }

        // GET: posties/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var posty = await _context.posties
                .FirstOrDefaultAsync(m => m.id_posty == id);
            if (posty == null)
            {
                return NotFound();
            }

            return View(posty);
        }

        // POST: posties/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var posty = await _context.posties.FindAsync(id);
            _context.posties.Remove(posty);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool postyExists(int id)
        {
            return _context.posties.Any(e => e.id_posty == id);
        }
    }
}
