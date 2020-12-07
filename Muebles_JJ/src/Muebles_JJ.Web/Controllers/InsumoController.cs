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
    public class InsumoController : Controller
    {
        private readonly Muebles_JJDbContext _context;

        public InsumoController(Muebles_JJDbContext context)
        {
            _context = context;
        }

        //GET: Insumo
        public async Task<IActionResult> Index()
        {
            var listado = await _context.Insumo.ToListAsync();
            return View(listado);
        }

        // GET: Insumo/Details/
        public async Task<IActionResult> Details(int? IdInsumo)
        {
            if (IdInsumo == null)
            {
                return NotFound();
            }

            Insumo model = await _context.Insumo
                .FirstOrDefaultAsync(m => m.IdInsumo == IdInsumo);
            if (model == null)
            {
                return NotFound();
            }

            return View(model);
        }


        //GET: Insumo/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Insumo Insumo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(Insumo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(Insumo);
        }

        [HttpGet]
        // GET: Insumo/Edit
        public async Task<IActionResult> Edit(int? IdInsumo)
        {
            if (IdInsumo == null)
            {
                return NotFound();
            }

            Insumo model = await _context.Insumo.FindAsync(IdInsumo);
            if (model == null)
            {
                return NotFound();
            }
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int IdInsumo, Insumo Insumo)
        {
            if (IdInsumo != Insumo.IdInsumo)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(Insumo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InsumoExists(Insumo.IdInsumo))
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
            return View(Insumo);
        }

        // GET: Insumo/Delete/5
        public async Task<IActionResult> Delete(int? IdInsumo)
        {
            if (IdInsumo == null)
            {
                return NotFound();
            }

            Insumo model = await _context.Insumo
                .FirstOrDefaultAsync(m => m.IdInsumo == IdInsumo);
            if (model == null)
            {
                return NotFound();
            }

            return View(model);
        }

        // POST: Insumo/Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int IdInsumo)
        {
            Insumo model = await _context.Insumo.FindAsync(IdInsumo);
            _context.Insumo.Remove(model);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        private bool InsumoExists(int IdInsumo)
        {
            return _context.Insumo.Any(c => c.IdInsumo == IdInsumo);
        }
    }
}
