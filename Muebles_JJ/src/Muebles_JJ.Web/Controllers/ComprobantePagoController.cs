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
    public class ComprobantePagoController : Controller
    {
        private readonly Muebles_JJDbContext _context;

        public ComprobantePagoController(Muebles_JJDbContext context)
        {
            _context = context;
        }

        //GET: ComprobantePago
        public async Task<IActionResult> Index()
        {
            var listado = await _context.ComprobantePago.ToListAsync();
            return View(listado);
        }

        // GET: ComprobantePago/Details/
        public async Task<IActionResult> Details(int? IdComprobante)
        {
            if (IdComprobante == null)
            {
                return NotFound();
            }

            ComprobantePago model = await _context.ComprobantePago
                .FirstOrDefaultAsync(m => m.IdComprobante == IdComprobante);
            if (model == null)
            {
                return NotFound();
            }

            return View(model);
        }


        //GET: ComprobantePago/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ComprobantePago ComprobantePago)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ComprobantePago);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ComprobantePago);
        }

        [HttpGet]
        // GET: ComprobantePago/Edit
        public async Task<IActionResult> Edit(int? IdComprobante)
        {
            if (IdComprobante == null)
            {
                return NotFound();
            }

            ComprobantePago model = await _context.ComprobantePago.FindAsync(IdComprobante);
            if (model == null)
            {
                return NotFound();
            }
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int IdComprobante, ComprobantePago ComprobantePago)
        {
            if (IdComprobante != ComprobantePago.IdComprobante)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ComprobantePago);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ComprobantePagoExists(ComprobantePago.IdComprobante))
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
            return View(ComprobantePago);
        }

        // GET: ComprobantePago/Delete/5
        public async Task<IActionResult> Delete(int? IdComprobante)
        {
            if (IdComprobante == null)
            {
                return NotFound();
            }

            ComprobantePago model = await _context.ComprobantePago
                .FirstOrDefaultAsync(m => m.IdComprobante == IdComprobante);
            if (model == null)
            {
                return NotFound();
            }

            return View(model);
        }

        // POST: ComprobantePago/Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int IdComprobante)
        {
            ComprobantePago model = await _context.ComprobantePago.FindAsync(IdComprobante);
            _context.ComprobantePago.Remove(model);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        private bool ComprobantePagoExists(int IdComprobante)
        {
            return _context.ComprobantePago.Any(c => c.IdComprobante == IdComprobante);
        }
    }
}
