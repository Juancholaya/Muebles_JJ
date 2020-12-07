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
    public class RolController : Controller
    {
        private readonly Muebles_JJDbContext _context;

        public RolController(Muebles_JJDbContext context)
        {
            _context = context;
        }

        //GET: Rol
        public async Task<IActionResult> Index()
        {
            var listado = await _context.Rol.ToListAsync();
            return View(listado);
        }

        // GET: Rol/Details/
        public async Task<IActionResult> Details(int? IdRol)
        {
            if (IdRol == null)
            {
                return NotFound();
            }

            Rol model = await _context.Rol
                .FirstOrDefaultAsync(m => m.IdRol == IdRol);
            if (model == null)
            {
                return NotFound();
            }

            return View(model);
        }


        //GET: Rol/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Rol Rol)
        {
            if (ModelState.IsValid)
            {
                _context.Add(Rol);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(Rol);
        }

        [HttpGet]
        // GET: Rol/Edit
        public async Task<IActionResult> Edit(int? IdRol)
        {
            if (IdRol == null)
            {
                return NotFound();
            }

            Rol model = await _context.Rol.FindAsync(IdRol);
            if (model == null)
            {
                return NotFound();
            }
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int IdRol, Rol Rol)
        {
            if (IdRol != Rol.IdRol)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(Rol);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RolExists(Rol.IdRol))
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
            return View(Rol);
        }

        // GET: Rol/Delete/5
        public async Task<IActionResult> Delete(int? IdRol)
        {
            if (IdRol == null)
            {
                return NotFound();
            }

            Rol model = await _context.Rol
                .FirstOrDefaultAsync(m => m.IdRol == IdRol);
            if (model == null)
            {
                return NotFound();
            }

            return View(model);
        }

        // POST: Rol/Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int IdRol)
        {
            Rol model = await _context.Rol.FindAsync(IdRol);
            _context.Rol.Remove(model);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        private bool RolExists(int IdRol)
        {
            return _context.Rol.Any(c => c.IdRol == IdRol);
        }
    }
}
