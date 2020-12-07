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
    public class ColorProductoController : Controller
    {
        private readonly Muebles_JJDbContext _context;

        public ColorProductoController(Muebles_JJDbContext context)
        {
            _context = context;
        }

        //GET: ColorProducto
        public async Task<IActionResult> Index()
        {
            var listado = await _context.ColorProducto.ToListAsync();
            return View(listado);
        }

        // GET: ColorProducto/Details/
        public async Task<IActionResult> Details(int? IdColor)
        {
            if (IdColor == null)
            {
                return NotFound();
            }

            ColorProducto model = await _context.ColorProducto
                .FirstOrDefaultAsync(m => m.IdColor == IdColor);
            if (model == null)
            {
                return NotFound();
            }

            return View(model);
        }


        //GET: ColorProducto/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Nombre")] ColorProducto colorProducto)
        {
            if (ModelState.IsValid)
            {
                _context.Add(colorProducto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(colorProducto);
        }

        [HttpGet]
        // GET: ColorProducto/Edit
        public async Task<IActionResult> Edit(int? IdColor)
        {
            if (IdColor == null)
            {
                return NotFound();
            }

            ColorProducto model = await _context.ColorProducto.FindAsync(IdColor);
            if (model == null)
            {
                return NotFound();
            }
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int IdColor, [Bind("IdColor,Nombre")] ColorProducto colorProducto)
        {
            if (IdColor != colorProducto.IdColor)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(colorProducto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ColorProductoExists(colorProducto.IdColor))
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
            return View(colorProducto);
        }

        // GET: ColorProducto/Delete/5
        public async Task<IActionResult> Delete(int? IdColor)
        {
            if (IdColor == null)
            {
                return NotFound();
            }

            ColorProducto model = await _context.ColorProducto
                .FirstOrDefaultAsync(m => m.IdColor == IdColor);
            if (model == null)
            {
                return NotFound();
            }

            return View(model);
        }

        // POST: ColorProducto/Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int IdColor)
        {
            ColorProducto model = await _context.ColorProducto.FindAsync(IdColor);
            _context.ColorProducto.Remove(model);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        private bool ColorProductoExists(int IdColor)
        {
            return _context.ColorProducto.Any(c => c.IdColor == IdColor);
        }
    }
}
