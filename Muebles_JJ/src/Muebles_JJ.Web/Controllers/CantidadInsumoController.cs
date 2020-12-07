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
    public class CantidadInsumoController : Controller
    {
        private readonly Muebles_JJDbContext _context;

        public CantidadInsumoController(Muebles_JJDbContext context)
        {
            _context = context;
        }

        //GET: CantidadInsumo
        public async Task<IActionResult> Index()
        {
            var listado = await _context.CantidadInsumo.ToListAsync();
            return View(listado);
        }

        // GET: CantidadInsumo/Details/
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CantidadInsumo model = await _context.CantidadInsumo
                .FirstOrDefaultAsync(m => m.IdCantidad == id);
            if (model == null)
            {
                return NotFound();
            }

            return View(model);
        }


        //GET: CantidadInsumo/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CantidadInsumo CantidadInsumo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(CantidadInsumo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(CantidadInsumo);
        }

        [HttpGet]
        // GET: CantidadInsumo/Edit
        public async Task<IActionResult> Edit(int? IdCantidad)
        {
            if (IdCantidad == null)
            {
                return NotFound();
            }

            CantidadInsumo model = await _context.CantidadInsumo.FindAsync(IdCantidad);
            if (model == null)
            {
                return NotFound();
            }
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int IdCantidad, CantidadInsumo CantidadInsumo)
        {
            if (IdCantidad != CantidadInsumo.IdCantidad)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(CantidadInsumo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CantidadInsumoExists(CantidadInsumo.IdCantidad))
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
            return View(CantidadInsumo);
        }

        // GET: CantidadInsumo/Delete/5
        public async Task<IActionResult> Delete(int? IdCantidad)
        {
            if (IdCantidad == null)
            {
                return NotFound();
            }

            CantidadInsumo model = await _context.CantidadInsumo
                .FirstOrDefaultAsync(m => m.IdCantidad == IdCantidad);
            if (model == null)
            {
                return NotFound();
            }

            return View(model);
        }

        // POST: CantidadInsumo/Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int IdCantidad)
        {
            CantidadInsumo model = await _context.CantidadInsumo.FindAsync(IdCantidad);
            _context.CantidadInsumo.Remove(model);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        private bool CantidadInsumoExists(int IdCantidad)
        {
            return _context.CantidadInsumo.Any(c => c.IdCantidad == IdCantidad);
        }
    }
}