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
    public class ProductoController : Controller
    {
        private readonly Muebles_JJDbContext _context;

            public ProductoController(Muebles_JJDbContext context)
            {
                _context = context;
            }

            //GET: Producto
            public async Task<IActionResult> Index()
            {
                var listado = await _context.Producto.ToListAsync();
                return View(listado);
            }

            // GET: Producto/Details/
            public async Task<IActionResult> Details(int? IdProducto)
            {
                if (IdProducto == null)
                {
                    return NotFound();
                }

                Producto model = await _context.Producto
                    .FirstOrDefaultAsync(m => m.IdProducto == IdProducto);
                if (model == null)
                {
                    return NotFound();
                }

                return View(model);
            }


            //GET: Producto/Create
            public IActionResult Create()
            {
                return View();
            }

            [HttpPost]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> Create(Producto Producto)
            {
                if (ModelState.IsValid)
                {
                    _context.Add(Producto);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                return View(Producto);
            }

            [HttpGet]
            // GET: Producto/Edit
            public async Task<IActionResult> Edit(int? IdProducto)
            {
                if (IdProducto == null)
                {
                    return NotFound();
                }

                Producto model = await _context.Producto.FindAsync(IdProducto);
                if (model == null)
                {
                    return NotFound();
                }
                return View(model);
            }

            [HttpPost]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> Edit(int IdProducto, Producto Producto)
            {
                if (IdProducto != Producto.IdProducto)
                {
                    return NotFound();
                }

                if (ModelState.IsValid)
                {
                    try
                    {
                        _context.Update(Producto);
                        await _context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!ProductoExists(Producto.IdProducto))
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
                return View(Producto);
            }

            // GET: Producto/Delete/5
            public async Task<IActionResult> Delete(int? IdProducto)
            {
                if (IdProducto == null)
                {
                    return NotFound();
                }

                Producto model = await _context.Producto
                    .FirstOrDefaultAsync(m => m.IdProducto == IdProducto);
                if (model == null)
                {
                    return NotFound();
                }

                return View(model);
            }

            // POST: Producto/Delete
            [HttpPost, ActionName("Delete")]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> DeleteConfirmed(int IdProducto)
            {
                Producto model = await _context.Producto.FindAsync(IdProducto);
                _context.Producto.Remove(model);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }


            private bool ProductoExists(int IdProducto)
            {
                return _context.Producto.Any(c => c.IdProducto == IdProducto);
            }
        }
    }
