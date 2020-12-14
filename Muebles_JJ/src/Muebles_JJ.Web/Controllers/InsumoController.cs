using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Muebles_JJ.Infrastructure.Data;
using Muebles_JJ.Infrastructure;
using Microsoft.AspNetCore.Http;
using Muebles_JJ.Web.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Muebles_JJ.Web.Controllers
{
    public class InsumoController : Controller
    {
        private readonly Muebles_JJDbContext _context;

        public InsumoController(Muebles_JJDbContext context)
        {
            _context = context;
        }

        //GET: Insumo
        public async Task<IActionResult> Index()
        {
            if (HttpContext.Session.GetString("Logueo") != "Si")
            {
                HttpContext.Session.SetString("MensajeError", "Su sesión expiró.");
                return RedirectToAction("Login", "Home");
            }
            InsumoModel model = new InsumoModel();
            model.listInsumo = await _context.Insumo.ToListAsync();
            model.listUnidadmedida = await _context.Unidadmedida.ToListAsync();
            return View(model);
        }

        //GET: Insumo/Create
        public async Task<IActionResult> Create()
        {
            if (HttpContext.Session.GetString("Logueo") != "Si")
            {
                HttpContext.Session.SetString("MensajeError", "Su sesión expiró.");
                return RedirectToAction("Login", "Home");
            }
            ViewData["UnidadMedida"] = new SelectList(_context.Unidadmedida, "IdMedida", "NombreLargo");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AgregarInsumo(InsumoModel model)
        {
            if (HttpContext.Session.GetString("Logueo") != "Si")
            {
                HttpContext.Session.SetString("MensajeError", "Su sesión expiró.");
                return RedirectToAction("Login", "Home");
            }
            _context.Add(model.oInsumo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        //GET: Insumo/Edit
        public async Task<IActionResult> Edit(int IdInsumo)
        {
            if (HttpContext.Session.GetString("Logueo") != "Si")
            {
                HttpContext.Session.SetString("MensajeError", "Su sesión expiró.");
                return RedirectToAction("Login", "Home");
            }
            InsumoModel model = new InsumoModel();
            model.oInsumo = await _context.Insumo.FindAsync(IdInsumo);
            ViewData["UnidadMedida"] = new SelectList(_context.Unidadmedida, "IdMedida", "NombreLargo");
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditarInsumo(InsumoModel model)
        {
            if (HttpContext.Session.GetString("Logueo") != "Si")
            {
                HttpContext.Session.SetString("MensajeError", "Su sesión expiró.");
                return RedirectToAction("Login", "Home");
            }
            _context.Update(model.oInsumo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        //GET: Insumo/EliminarInsumo
        public async Task<IActionResult> EliminarInsumo(int IdInsumo)
        {
            if (HttpContext.Session.GetString("Logueo") != "Si")
            {
                HttpContext.Session.SetString("MensajeError", "Su sesión expiró.");
                return RedirectToAction("Login", "Home");
            }
            Insumo model = await _context.Insumo.FindAsync(IdInsumo);
            _context.Insumo.Remove(model);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
