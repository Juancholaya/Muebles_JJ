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
    public class PersonaController : Controller
    {
            private readonly Muebles_JJDbContext _context;

            public PersonaController(Muebles_JJDbContext context)
            {
                _context = context;
            }

            //GET: Persona
            public async Task<IActionResult> Index()
            {
                var listado = await _context.Persona.ToListAsync();
                return View(listado);
            }

            // GET: Persona/Details/
            public async Task<IActionResult> Details(int? IdPersona)
            {
                if (IdPersona == null)
                {
                    return NotFound();
                }

                Persona model = await _context.Persona
                    .FirstOrDefaultAsync(m => m.IdPersona == IdPersona);
                if (model == null)
                {
                    return NotFound();
                }

                return View(model);
            }


            //GET: Persona/Create
            public IActionResult Create()
            {
                return View();
            }

            [HttpPost]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> Create(Persona Persona)
            {
                if (ModelState.IsValid)
                {
                    _context.Add(Persona);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                return View(Persona);
            }

            [HttpGet]
            // GET: Persona/Edit
            public async Task<IActionResult> Edit(int? IdPersona)
            {
                if (IdPersona == null)
                {
                    return NotFound();
                }

                Persona model = await _context.Persona.FindAsync(IdPersona);
                if (model == null)
                {
                    return NotFound();
                }
                return View(model);
            }

            [HttpPost]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> Edit(int IdPersona, Persona Persona)
            {
                if (IdPersona != Persona.IdPersona)
                {
                    return NotFound();
                }

                if (ModelState.IsValid)
                {
                    try
                    {
                        _context.Update(Persona);
                        await _context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!PersonaExists(Persona.IdPersona))
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
                return View(Persona);
            }

            // GET: Persona/Delete/5
            public async Task<IActionResult> Delete(int? IdPersona)
            {
                if (IdPersona == null)
                {
                    return NotFound();
                }

                Persona model = await _context.Persona
                    .FirstOrDefaultAsync(m => m.IdPersona == IdPersona);
                if (model == null)
                {
                    return NotFound();
                }

                return View(model);
            }

            // POST: Persona/Delete
            [HttpPost, ActionName("Delete")]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> DeleteConfirmed(int IdPersona)
            {
                Persona model = await _context.Persona.FindAsync(IdPersona);
                _context.Persona.Remove(model);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }


            private bool PersonaExists(int IdPersona)
            {
                return _context.Persona.Any(c => c.IdPersona == IdPersona);
            }
        }
    }
