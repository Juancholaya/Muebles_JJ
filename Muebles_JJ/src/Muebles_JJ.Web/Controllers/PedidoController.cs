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
    public class PedidoController : Controller
    {
        private readonly Muebles_JJDbContext _context;

        public PedidoController(Muebles_JJDbContext context)
        {
            _context = context;
        }

        //GET: Pedido
        public async Task<IActionResult> Index()
        {
            var listado = await _context.Pedido.ToListAsync();
            return View(listado);
        }

        // GET: Pedido/Details/
        public async Task<IActionResult> Details(int? IdPedido)
        {
            if (IdPedido == null)
            {
                return NotFound();
            }

            Pedido model = await _context.Pedido
                .FirstOrDefaultAsync(m => m.IdPedido == IdPedido);
            if (model == null)
            {
                return NotFound();
            }

            return View(model);
        }


        //GET: Pedido/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Pedido Pedido)
        {
            if (ModelState.IsValid)
            {
                _context.Add(Pedido);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(Pedido);
        }

        [HttpGet]
        // GET: Pedido/Edit
        public async Task<IActionResult> Edit(int? IdPedido)
        {
            if (IdPedido == null)
            {
                return NotFound();
            }

            Pedido model = await _context.Pedido.FindAsync(IdPedido);
            if (model == null)
            {
                return NotFound();
            }
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int IdPedido, Pedido Pedido)
        {
            if (IdPedido != Pedido.IdPedido)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(Pedido);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PedidoExists(Pedido.IdPedido))
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
            return View(Pedido);
        }

        // GET: Pedido/Delete/5
        public async Task<IActionResult> Delete(int? IdPedido)
        {
            if (IdPedido == null)
            {
                return NotFound();
            }

            Pedido model = await _context.Pedido
                .FirstOrDefaultAsync(m => m.IdPedido == IdPedido);
            if (model == null)
            {
                return NotFound();
            }

            return View(model);
        }

        // POST: Pedido/Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int IdPedido)
        {
            Pedido model = await _context.Pedido.FindAsync(IdPedido);
            _context.Pedido.Remove(model);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        private bool PedidoExists(int IdPedido)
        {
            return _context.Pedido.Any(c => c.IdPedido == IdPedido);
        }
    }
}
