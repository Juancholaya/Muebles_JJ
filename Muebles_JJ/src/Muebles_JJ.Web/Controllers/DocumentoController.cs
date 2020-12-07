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
    public class DocumentoController : Controller
    {
            private readonly Muebles_JJDbContext _context;

            public DocumentoController(Muebles_JJDbContext context)
            {
                _context = context;
            }

            //GET: ComprobantePago
            public async Task<IActionResult> Index()
            {
                var listado = await _context.Documento.ToListAsync();
                return View(listado);
            }

            // GET: ComprobantePago/Details/
            public async Task<IActionResult> Details(int? IdDocumento)
            {
                if (IdDocumento == null)
                {
                    return NotFound();
                }

                Documento model = await _context.Documento
                    .FirstOrDefaultAsync(m => m.IdDocumento == IdDocumento);
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

            //POST: ComprobantePago/Create
            [HttpPost]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> Create([Bind("Tipo")] Documento documento)
            {
                if (ModelState.IsValid)
                {
                    _context.Add(documento);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                return View(documento);
            }

            [HttpGet]
            // GET: ComprobantePago/Edit
            public async Task<IActionResult> Edit(int? IdDocumento)
            {
                if (IdDocumento == null)
                {
                    return NotFound();
                }

                Documento model = await _context.Documento.FindAsync(IdDocumento);
                if (model == null)
                {
                    return NotFound();
                }
                return View(model);
            }

            // POST: ComprobantePago/Edit
            [HttpPost]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> Edit(int IdDocumento, [Bind("Tipo")] Documento documento)
            {
                if (IdDocumento != documento.IdDocumento)
                {
                    return NotFound();
                }

                if (ModelState.IsValid)
                {
                    try
                    {
                        _context.Update(documento);
                        await _context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!DocumentoExists(documento.IdDocumento))
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
                return View(documento);
            }

            // GET: ComprobantePago/Delete/5
            public async Task<IActionResult> Delete(int? IdDocumento)
            {
                if (IdDocumento == null)
                {
                    return NotFound();
                }

                Documento model = await _context.Documento
                    .FirstOrDefaultAsync(m => m.IdDocumento == IdDocumento);
                if (model == null)
                {
                    return NotFound();
                }

                return View(model);
            }

            // POST: ComprobantePago/Delete
            [HttpPost, ActionName("Delete")]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> DeleteConfirmed(int IdDocumento)
            {
                Documento model = await _context.Documento.FindAsync(IdDocumento);
                _context.Documento.Remove(model);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            private bool DocumentoExists(int IdDocumento)
            {
                return _context.Documento.Any(c => c.IdDocumento == IdDocumento);
            }
        }
}
