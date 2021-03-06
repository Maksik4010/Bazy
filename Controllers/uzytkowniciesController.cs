﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using WebApplication16.Data;
using WebApplication16.Models;
using System.Web;

namespace Portal.Controllers
{
    public class uzytkowniciesController : Controller
    {
        private readonly ApplicationDbContext _context;

        //private readonly SignInManager<IdentityUser> _signInManager;
        private readonly ILogger _logger;
        private readonly UserManager<IdentityUser> _userManager;
        //private bool status = false;


        public uzytkowniciesController(ApplicationDbContext context, ILogger<uzytkowniciesController> logger,UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
           //_signInManager = signInManager;
            _logger = logger;
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

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {
 
            return View();
        }

     
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(uzytkownicy model)
        {
           
               var b = _context.uzytkownicies.Where(a => a.login == model.login && a.haslo == model.haslo).FirstOrDefault();
                if (b != null)
                {
                TempData["imie"] = model.login;
                return RedirectToAction("Index", "posties", new { id  = 1}) ;
                
                }
            return View();

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
               // uzytkownicy.login = _userManager.
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
