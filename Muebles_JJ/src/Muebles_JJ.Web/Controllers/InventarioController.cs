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
    public class InventarioController : Controller
    {
        private readonly Muebles_JJDbContext _context;

        public InventarioController(Muebles_JJDbContext context)
        {
            _context = context;
        }

        //GET: Inventario
        public async Task<IActionResult> Index()
        {
            var listado = await _context.Inventario.ToListAsync();
            return View(listado);
        }

        // GET: Inventario/Details/
        public async Task<IActionResult> Details(int? IdInventario)
        {
            if (IdInventario == null)
            {
                return NotFound();
            }

            Inventario model = await _context.Inventario
                .FirstOrDefaultAsync(m => m.IdInventario == IdInventario);
            if (model == null)
            {
                return NotFound();
            }

            return View(model);
        }


        //GET: Inventario/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Inventario Inventario)
        {
            if (ModelState.IsValid)
            {
                _context.Add(Inventario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(Inventario);
        }

        [HttpGet]
        // GET: Inventario/Edit
        public async Task<IActionResult> Edit(int? IdInventario)
        {
            if (IdInventario == null)
            {
                return NotFound();
            }

            Inventario model = await _context.Inventario.FindAsync(IdInventario);
            if (model == null)
            {
                return NotFound();
            }
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int IdInventario, Inventario Inventario)
        {
            if (IdInventario != Inventario.IdInventario)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(Inventario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InventarioExists(Inventario.IdInventario))
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
            return View(Inventario);
        }

        // GET: Inventario/Delete/5
        public async Task<IActionResult> Delete(int? IdInventario)
        {
            if (IdInventario == null)
            {
                return NotFound();
            }

            Inventario model = await _context.Inventario
                .FirstOrDefaultAsync(m => m.IdInventario == IdInventario);
            if (model == null)
            {
                return NotFound();
            }

            return View(model);
        }

        // POST: Inventario/Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int IdInventario)
        {
            Inventario model = await _context.Inventario.FindAsync(IdInventario);
            _context.Inventario.Remove(model);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        private bool InventarioExists(int IdInventario)
        {
            return _context.Inventario.Any(c => c.IdInventario == IdInventario);
        }
    }
}
