﻿using System;
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
        public async Task<IActionResult> Index(int id)
        {
            if(id == 1)
            {
                ViewBag.status = true;
                ViewBag.imie = TempData["imie"];
                //var b = _context.uzytkownicies.Where(a => a.id == ide).ToString();
                //ViewBag.imie = id ;
                return View(await _context.posties.ToListAsync());
            }

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
                .FirstOrDefaultAsync(m => m.id == id);
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
        public async Task<IActionResult> Create([Bind("id,typ,id_uzytkownika,tresc,data_utworzenia,liczba_like,liczba_dislike,status_komentarzy")] posty posty)
        {
            if (ModelState.IsValid)
            {
                posty.typ = 0; //post publiczny
                //posty.id_uzytkownika =  TODO
                posty.data_utworzenia = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds();
                posty.status_komentarzy = 1; //wlaczone
                _context.Add(posty);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index), new { id = 1 });
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
            if (id != posty.id)
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
                    if (!postyExists(posty.id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index), new { id = 1 });
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
                .FirstOrDefaultAsync(m => m.id == id);
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
            return RedirectToAction(nameof(Index), new { id = 1 });
        }

        private bool postyExists(int id)
        {
            return _context.posties.Any(e => e.id == id);
        }

        public uzytkownicy getUser(int id)
        {
            return _context.uzytkownicies.Find(id);
        }
    }
}
