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
    public class MaterialProductoController : Controller
    {
        private readonly Muebles_JJDbContext _context;

        public MaterialProductoController(Muebles_JJDbContext context)
        {
            _context = context;
        }

        //GET: MaterialProducto
        public async Task<IActionResult> Index()
        {
            var listado = await _context.MaterialProducto.ToListAsync();
            return View(listado);
        }

        // GET: MaterialProducto/Details/
        public async Task<IActionResult> Details(int? IdMaterial)
        {
            if (IdMaterial == null)
            {
                return NotFound();
            }

            MaterialProducto model = await _context.MaterialProducto
                .FirstOrDefaultAsync(m => m.IdMaterial == IdMaterial);
            if (model == null)
            {
                return NotFound();
            }

            return View(model);
        }


        //GET: MaterialProducto/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(MaterialProducto MaterialProducto)
        {
            if (ModelState.IsValid)
            {
                _context.Add(MaterialProducto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(MaterialProducto);
        }

        [HttpGet]
        // GET: MaterialProducto/Edit
        public async Task<IActionResult> Edit(int? IdMaterial)
        {
            if (IdMaterial == null)
            {
                return NotFound();
            }

            MaterialProducto model = await _context.MaterialProducto.FindAsync(IdMaterial);
            if (model == null)
            {
                return NotFound();
            }
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int IdMaterial, MaterialProducto MaterialProducto)
        {
            if (IdMaterial != MaterialProducto.IdMaterial)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(MaterialProducto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MaterialProductoExists(MaterialProducto.IdMaterial))
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
            return View(MaterialProducto);
        }

        // GET: MaterialProducto/Delete/5
        public async Task<IActionResult> Delete(int? IdMaterial)
        {
            if (IdMaterial == null)
            {
                return NotFound();
            }

            MaterialProducto model = await _context.MaterialProducto
                .FirstOrDefaultAsync(m => m.IdMaterial == IdMaterial);
            if (model == null)
            {
                return NotFound();
            }

            return View(model);
        }

        // POST: MaterialProducto/Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int IdMaterial)
        {
            MaterialProducto model = await _context.MaterialProducto.FindAsync(IdMaterial);
            _context.MaterialProducto.Remove(model);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        private bool MaterialProductoExists(int IdMaterial)
        {
            return _context.MaterialProducto.Any(c => c.IdMaterial == IdMaterial);
        }
    }
}
