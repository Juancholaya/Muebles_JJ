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
    public class UsuarioController : Controller
    {
        private readonly Muebles_JJDbContext _context;

        public UsuarioController(Muebles_JJDbContext context)
        {
            _context = context;
        }

        //GET: Usuario
        public async Task<IActionResult> Index()
        {
            var listado = await _context.Usuario.ToListAsync();
            return View(listado);
        }

        // GET: Usuario/Details/
        public async Task<IActionResult> Details(int? IdUsuario)
        {
            if (IdUsuario == null)
            {
                return NotFound();
            }

            Usuario model = await _context.Usuario
                .FirstOrDefaultAsync(m => m.IdUsuario == IdUsuario);
            if (model == null)
            {
                return NotFound();
            }

            return View(model);
        }


        //GET: Usuario/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Usuario Usuario)
        {
            if (ModelState.IsValid)
            {
                _context.Add(Usuario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(Usuario);
        }

        [HttpGet]
        // GET: Usuario/Edit
        public async Task<IActionResult> Edit(int? IdUsuario)
        {
            if (IdUsuario == null)
            {
                return NotFound();
            }

            Usuario model = await _context.Usuario.FindAsync(IdUsuario);
            if (model == null)
            {
                return NotFound();
            }
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int IdUsuario, Usuario Usuario)
        {
            if (IdUsuario != Usuario.IdUsuario)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(Usuario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UsuarioExists(Usuario.IdUsuario))
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
            return View(Usuario);
        }

        // GET: Usuario/Delete/5
        public async Task<IActionResult> Delete(int? IdUsuario)
        {
            if (IdUsuario == null)
            {
                return NotFound();
            }

            Usuario model = await _context.Usuario
                .FirstOrDefaultAsync(m => m.IdUsuario == IdUsuario);
            if (model == null)
            {
                return NotFound();
            }

            return View(model);
        }

        // POST: Usuario/Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int IdUsuario)
        {
            Usuario model = await _context.Usuario.FindAsync(IdUsuario);
            _context.Usuario.Remove(model);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        private bool UsuarioExists(int IdUsuario)
        {
            return _context.Usuario.Any(c => c.IdUsuario == IdUsuario);
        }
    }
}
