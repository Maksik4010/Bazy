﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication16.Data;
using WebApplication16.Models;

namespace Portal.Controllers
{
    public class zdjeciasController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IHostingEnvironment he;

        public zdjeciasController(ApplicationDbContext context, UserManager<IdentityUser> userManager, IHostingEnvironment e)
        {
            _context = context;
            _userManager = userManager;
            he = e;
        }

        // GET: zdjecias
        public async Task<IActionResult> Index()
        {
            return View(await _context.zdjecias.ToListAsync());
        }

        // GET: zdjecias/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var zdjecia = await _context.zdjecias
                .FirstOrDefaultAsync(m => m.Id_zjecia == id);
            if (zdjecia == null)
            {
                return NotFound();
            }

            return View(zdjecia);
        }

        // GET: zdjecias/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: zdjecias/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<IActionResult> Create([Bind("Id_zjecia,nazwa,Id_użytkownicy,link_bezposredni")] zdjecia image, IFormFile file)
        {
            if (file == null)
            {
                ViewBag.String = "Brak wybranego pliku!";
                return View("~/Views/Images/Erroe.cshtml");
            }
            if ((file.Length / 1048576.0) > 5) //rozmiar wiekszy niż 5 mb
            {
                ViewBag.String = "Plik za duży!";
                return View("~/Views/Images/Erroe.cshtml");
            }

            string extension = Path.GetExtension(file.FileName);
            if ((extension == ".jpg") || (extension == ".png"))
            {

                var filename = Path.Combine(he.WebRootPath, Path.GetFileName(file.FileName));

                using (var stream = new FileStream(filename, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }



                var userId = _userManager.GetUserId(HttpContext.User);
                if (ModelState.IsValid)
                {

                    image.link_bezposredni = "/" + file.FileName;
                    _context.Add(image);

                    await _context.SaveChangesAsync();

                    return RedirectToAction("Index", "posties");
                }

                return View(image);

            }
            ViewBag.String = "Błędny typ pliku!";
            return View("~/Views/Images/Erroe.cshtml");
        }

        // GET: zdjecias/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var zdjecia = await _context.zdjecias.FindAsync(id);
            if (zdjecia == null)
            {
                return NotFound();
            }
            return View(zdjecia);
        }

        // POST: zdjecias/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id_zjecia,nazwa,Id_użytkownicy,link_bezposredni")] zdjecia zdjecia)
        {
            if (id != zdjecia.Id_zjecia)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(zdjecia);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!zdjeciaExists(zdjecia.Id_zjecia))
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
            return View(zdjecia);
        }

        // GET: zdjecias/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var zdjecia = await _context.zdjecias
                .FirstOrDefaultAsync(m => m.Id_zjecia == id);
            if (zdjecia == null)
            {
                return NotFound();
            }

            return View(zdjecia);
        }

        // POST: zdjecias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var zdjecia = await _context.zdjecias.FindAsync(id);
            _context.zdjecias.Remove(zdjecia);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool zdjeciaExists(int id)
        {
            return _context.zdjecias.Any(e => e.Id_zjecia == id);
        }
    }
}
