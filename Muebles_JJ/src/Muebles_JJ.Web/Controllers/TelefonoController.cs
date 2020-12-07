using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Muebles_JJ.Infrastructure.Data;
using Muebles_JJ.Infrastructure;

namespace Muebles_JJ.Web.Controllers
{
    public class TelefonoController : Controller
    {
        private readonly Muebles_JJDbContext _context;

        public TelefonoController(Muebles_JJDbContext context)
        {
            _context = context;
        }

        //GET: Telefono
        public async Task<IActionResult> Index()
        {
            var listado = await _context.Telefono.ToListAsync();
            return View(listado);
        }

        // GET: Telefono/Details/
        public async Task<IActionResult> Details(int? IdTelefono)
        {
            if (IdTelefono == null)
            {
                return NotFound();
            }

            Telefono model = await _context.Telefono
                .FirstOrDefaultAsync(m => m.IdTelefono == IdTelefono);
            if (model == null)
            {
                return NotFound();
            }

            return View(model);
        }


        //GET: Telefono/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Telefono Telefono)
        {
            if (ModelState.IsValid)
            {
                _context.Add(Telefono);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(Telefono);
        }

        [HttpGet]
        // GET: Telefono/Edit
        public async Task<IActionResult> Edit(int? IdTelefono)
        {
            if (IdTelefono == null)
            {
                return NotFound();
            }

            Telefono model = await _context.Telefono.FindAsync(IdTelefono);
            if (model == null)
            {
                return NotFound();
            }
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int IdTelefono, Telefono Telefono)
        {
            if (IdTelefono != Telefono.IdTelefono)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(Telefono);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TelefonoExists(Telefono.IdTelefono))
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
            return View(Telefono);
        }

        // GET: Telefono/Delete/5
        public async Task<IActionResult> Delete(int? IdTelefono)
        {
            if (IdTelefono == null)
            {
                return NotFound();
            }

            Telefono model = await _context.Telefono
                .FirstOrDefaultAsync(m => m.IdTelefono == IdTelefono);
            if (model == null)
            {
                return NotFound();
            }

            return View(model);
        }

        // POST: Telefono/Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int IdTelefono)
        {
            Telefono model = await _context.Telefono.FindAsync(IdTelefono);
            _context.Telefono.Remove(model);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        private bool TelefonoExists(int IdTelefono)
        {
            return _context.Telefono.Any(c => c.IdTelefono == IdTelefono);
        }
    }
}
