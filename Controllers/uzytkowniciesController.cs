using System;
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

namespace Portal.Controllers
{
    public class uzytkowniciesController : Controller
    {
        private readonly ApplicationDbContext _context;

        private readonly SignInManager<uzytkownicy> _signInManager;
        private readonly ILogger _logger;


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
                .FirstOrDefaultAsync(m => m.Id_uzytkownicy == id);
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

        //    [HttpPost]
        //    [AllowAnonymous]
        //    [ValidateAntiForgeryToken]
        //    public async Task<IActionResult> Login(uzytkownicy model, string returnUrl = null)
        //    {
        //        ViewData["ReturnUrl"] = returnUrl;
        //        if (ModelState.IsValid)
        //         {
        //            var result = await _signInManager.PasswordSignInAsync(model.login, model.haslo, false, lockoutOnFailure: false);
        //            if (result.Succeeded)
        //            {
        //                _logger.LogInformation(1, "User logged in.");
        //                return View(returnUrl);
        //            }
        //            //if (result.RequiresTwoFactor)
        //            //{
        //            //    return RedirectToAction(nameof(SendCode), new { ReturnUrl = returnUrl,  });
        //            //}
        //            if (result.IsLockedOut)
        //            {
        //                _logger.LogWarning(2, "User account locked out.");
        //                return View("Lockout");
        //            }
        //            else
        //            {
        //                ModelState.AddModelError(string.Empty, "Invalid login attempt.");
        //               // return View(model);
        //            }
        //         }

        //        // If we got this far, something failed, redisplay form
        //        return View(model);


        //}
        //var result = _context.uzytkownicies.FirstOrDefault(m => m.imie == Login);
        ////if (ModelState.IsValid)
        ////{

        ////}
        //if(result == null)
        //{
        //    return NotFound();
        //}
        //else
        //    return View("Index");

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(string login, string haslo)
        {

            //var result = _context.uzytkownicies.FirstOrDefaultAsync(e => e.login == uzytkownicy.login && e.haslo == uzytkownicy.haslo);

            //    if(result == null)
            //    {
            //        return RedirectToAction(nameof(Index));
            //    }

            var uzytkownicyL = await _context.uzytkownicies.FirstOrDefaultAsync(m => m.login == login);
            var uzytkownicyH = await _context.uzytkownicies.FirstOrDefaultAsync(m => m.haslo == haslo);
            if (uzytkownicyL == null || uzytkownicyH == null)
            {
                return View(uzytkownicyL);
            }

            return RedirectToAction("Index", "posties");

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
        public async Task<IActionResult> Create([Bind("Id_uzytkownicy,login,haslo,imie,nazwisko,ksywka,data_zalozenia,ostatnie_logowanie,ip_ostatniego_logowania,kraj,liczba_znajomych")] uzytkownicy uzytkownicy)
        {
            if (ModelState.IsValid)
            {
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
        public async Task<IActionResult> Edit(int id, [Bind("Id_uzytkownicy,login,haslo,imie,nazwisko,ksywka,data_zalozenia,ostatnie_logowanie,ip_ostatniego_logowania,kraj,liczba_znajomych")] uzytkownicy uzytkownicy)
        {
            if (id != uzytkownicy.Id_uzytkownicy)
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
                    if (!uzytkownicyExists(uzytkownicy.Id_uzytkownicy))
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
                .FirstOrDefaultAsync(m => m.Id_uzytkownicy == id);
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
            return _context.uzytkownicies.Any(e => e.Id_uzytkownicy == id);
        }

        
    }
}
