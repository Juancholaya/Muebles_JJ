using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Muebles_JJ.Web.Models;
using Muebles_JJ.Infrastructure;
using Muebles_JJ.Infrastructure.Data;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Muebles_JJ.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly Muebles_JJDbContext _context;

        public HomeController(Muebles_JJDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Registro()
        {
            ViewData["TipoDocumento"] = new SelectList(_context.Documento, "IdDocumento", "Tipo");
            ViewData["TipoRol"] = new SelectList(_context.Rol, "IdRol", "Nombre");
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(RegistroModel registroModel)
        {
            if (ModelState.IsValid)
            {
               _context.Add(registroModel.oPersona);
                await _context.SaveChangesAsync();
                registroModel.oUsuario.IdPersonaFk = registroModel.oPersona.IdPersona;
                _context.Add(registroModel.oUsuario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(registroModel);
        }
    }
}