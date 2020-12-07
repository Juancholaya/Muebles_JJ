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
    public class MedidaProductoController : Controller
    {
        private readonly Muebles_JJDbContext _context;

        public MedidaProductoController(Muebles_JJDbContext context)
        {
            _context = context;
        }

        //GET: MedidaProducto
        public async Task<IActionResult> Index()
        {
            var listado = await _context.MedidaProducto.ToListAsync();
            return View(listado);
        }

        // GET: MedidaProducto/Details/
        public async Task<IActionResult> Details(int? IdMedida)
        {
            if (IdMedida == null)
            {
                return NotFound();
            }

            MedidaProducto model = await _context.MedidaProducto
                .FirstOrDefaultAsync(m => m.IdMedida == IdMedida);
            if (model == null)
            {
                return NotFound();
            }

            return View(model);
        }


        //GET: MedidaProducto/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(MedidaProducto MedidaProducto)
        {
            if (ModelState.IsValid)
            {
                _context.Add(MedidaProducto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(MedidaProducto);
        }

        [HttpGet]
        // GET: MedidaProducto/Edit
        public async Task<IActionResult> Edit(int? IdMedida)
        {
            if (IdMedida == null)
            {
                return NotFound();
            }

            MedidaProducto model = await _context.MedidaProducto.FindAsync(IdMedida);
            if (model == null)
            {
                return NotFound();
            }
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int IdMedida, MedidaProducto MedidaProducto)
        {
            if (IdMedida != MedidaProducto.IdMedida)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(MedidaProducto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MedidaProductoExists(MedidaProducto.IdMedida))
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
            return View(MedidaProducto);
        }

        // GET: MedidaProducto/Delete/5
        public async Task<IActionResult> Delete(int? IdMedida)
        {
            if (IdMedida == null)
            {
                return NotFound();
            }

            MedidaProducto model = await _context.MedidaProducto
                .FirstOrDefaultAsync(m => m.IdMedida == IdMedida);
            if (model == null)
            {
                return NotFound();
            }

            return View(model);
        }

        // POST: MedidaProducto/Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int IdMedida)
        {
            MedidaProducto model = await _context.MedidaProducto.FindAsync(IdMedida);
            _context.MedidaProducto.Remove(model);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        private bool MedidaProductoExists(int IdMedida)
        {
            return _context.MedidaProducto.Any(c => c.IdMedida == IdMedida);
        }
    }
}
