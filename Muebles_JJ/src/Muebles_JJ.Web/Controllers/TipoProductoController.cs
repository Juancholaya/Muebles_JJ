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
    public class TipoProductoController : Controller
    {
        private readonly Muebles_JJDbContext _context;

        public TipoProductoController(Muebles_JJDbContext context)
        {
            _context = context;
        }

        //GET: TipoProducto
        public async Task<IActionResult> Index()
        {
            var listado = await _context.TipoProducto.ToListAsync();
            return View(listado);
        }

        // GET: TipoProducto/Details/
        public async Task<IActionResult> Details(int? IdTipo)
        {
            if (IdTipo == null)
            {
                return NotFound();
            }

            TipoProducto model = await _context.TipoProducto
                .FirstOrDefaultAsync(m => m.IdTipo == IdTipo);
            if (model == null)
            {
                return NotFound();
            }

            return View(model);
        }


        //GET: TipoProducto/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TipoProducto TipoProducto)
        {
            if (ModelState.IsValid)
            {
                _context.Add(TipoProducto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(TipoProducto);
        }

        [HttpGet]
        // GET: TipoProducto/Edit
        public async Task<IActionResult> Edit(int? IdTipo)
        {
            if (IdTipo == null)
            {
                return NotFound();
            }

            TipoProducto model = await _context.TipoProducto.FindAsync(IdTipo);
            if (model == null)
            {
                return NotFound();
            }
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int IdTipo, TipoProducto TipoProducto)
        {
            if (IdTipo != TipoProducto.IdTipo)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(TipoProducto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TipoProductoExists(TipoProducto.IdTipo))
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
            return View(TipoProducto);
        }

        // GET: TipoProducto/Delete/5
        public async Task<IActionResult> Delete(int? IdTipo)
        {
            if (IdTipo == null)
            {
                return NotFound();
            }

            TipoProducto model = await _context.TipoProducto
                .FirstOrDefaultAsync(m => m.IdTipo == IdTipo);
            if (model == null)
            {
                return NotFound();
            }

            return View(model);
        }

        // POST: TipoProducto/Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int IdTipo)
        {
            TipoProducto model = await _context.TipoProducto.FindAsync(IdTipo);
            _context.TipoProducto.Remove(model);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        private bool TipoProductoExists(int IdTipo)
        {
            return _context.TipoProducto.Any(c => c.IdTipo == IdTipo);
        }
    }
}
