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
    public class VentaController : Controller
    {
        private readonly Muebles_JJDbContext _context;

        public VentaController(Muebles_JJDbContext context)
        {
            _context = context;
        }

        //GET: Venta
        public async Task<IActionResult> Index()
        {
            var listado = await _context.Venta.ToListAsync();
            return View(listado);
        }

        // GET: Venta/Details/
        public async Task<IActionResult> Details(int? IdVenta)
        {
            if (IdVenta == null)
            {
                return NotFound();
            }

            Venta model = await _context.Venta
                .FirstOrDefaultAsync(m => m.IdVenta == IdVenta);
            if (model == null)
            {
                return NotFound();
            }

            return View(model);
        }


        //GET: Venta/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Venta Venta)
        {
            if (ModelState.IsValid)
            {
                _context.Add(Venta);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(Venta);
        }

        [HttpGet]
        // GET: Venta/Edit
        public async Task<IActionResult> Edit(int? IdVenta)
        {
            if (IdVenta == null)
            {
                return NotFound();
            }

            Venta model = await _context.Venta.FindAsync(IdVenta);
            if (model == null)
            {
                return NotFound();
            }
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int IdVenta, Venta Venta)
        {
            if (IdVenta != Venta.IdVenta)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(Venta);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VentaExists(Venta.IdVenta))
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
            return View(Venta);
        }

        // GET: Venta/Delete/5
        public async Task<IActionResult> Delete(int? IdVenta)
        {
            if (IdVenta == null)
            {
                return NotFound();
            }

            Venta model = await _context.Venta
                .FirstOrDefaultAsync(m => m.IdVenta == IdVenta);
            if (model == null)
            {
                return NotFound();
            }

            return View(model);
        }

        // POST: Venta/Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int IdVenta)
        {
            Venta model = await _context.Venta.FindAsync(IdVenta);
            _context.Venta.Remove(model);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        private bool VentaExists(int IdVenta)
        {
            return _context.Venta.Any(c => c.IdVenta == IdVenta);
        }
    }
}
