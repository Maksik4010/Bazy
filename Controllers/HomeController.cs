using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication16.Models;
using WebApplication16.Data;

namespace WebApplication16.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public IActionResult Index()
        {
            return View();
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
        /*
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
                return RedirectToAction(nameof(Index));
            }
            return View(posty);
        }*/
    }
}
