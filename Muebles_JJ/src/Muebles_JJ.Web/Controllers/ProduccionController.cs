using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Muebles_JJ.Infrastructure;
using Muebles_JJ.Web.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Http;
using Muebles_JJ.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Muebles_JJ.Web.Controllers
{
    public class ProduccionController : Controller
    {
        private readonly Muebles_JJDbContext _context;

        public ProduccionController(Muebles_JJDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            if (HttpContext.Session.GetString("Logueo") != "Si")
            {
                HttpContext.Session.SetString("MensajeError", "Su sesión expiró.");
                return RedirectToAction("Login", "Home");
            }
            ViewData["Documento"] = await _context.Documento.ToListAsync();
            var listado = await _context.Venta.ToListAsync();
            return View(listado);
        }
    }
}