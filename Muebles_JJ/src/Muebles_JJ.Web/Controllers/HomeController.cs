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
using System.Web;
using Microsoft.AspNetCore.Http;

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
            HttpContext.Session.Clear();
            return View();
        }
        public IActionResult Registro()
        {
            if (HttpContext.Session.GetString("Logueo") == "Si")
            {
                ViewData["TipoDocumento"] = new SelectList(_context.Documento, "IdDocumento", "Tipo");
                ViewData["TipoRol"] = new SelectList(_context.Rol, "IdRol", "Nombre");
                return View();
            }
            ViewData["MensajeError"] = "Su sesión expiró.";
            return View(nameof(Login));
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
                return RedirectToAction(nameof(ConsultaUsuario));
            }
            return View(registroModel);
        }
        public IActionResult Login()
        {
            ViewData["MensajeError"] = HttpContext.Session.GetString("MensajeError");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(Usuario usuarioModel)
        {
            if (ModelState.IsValid)
            {
                if (_context.Usuario.Any(c => c.NombreUsuario == usuarioModel.NombreUsuario && c.ContraseñaUsuario == usuarioModel.ContraseñaUsuario))
                {
                    HttpContext.Session.SetString("Logueo", "Si");
                    return RedirectToAction(nameof(Inicial));
                }
            }
            HttpContext.Session.SetString("MensajeError", "Usuario o contraseña incorrecta.");
            return RedirectToAction(nameof(Login), "Home");
        }

        public IActionResult Inicial()
        {
            if (HttpContext.Session.GetString("Logueo") == "Si")
            {
                return View();
            }
            ViewData["MensajeError"] = "Su sesión expiró.";
            return View(nameof(Login));

        }

        public IActionResult ConsultaUsuario()
        {
            if (HttpContext.Session.GetString("Logueo") == "Si")
            {
                ViewData["TipoRol"] = _context.Rol.ToList();
                List<Usuario> model = _context.Usuario.ToList();
                return View(model);
            }
            ViewData["MensajeError"] = "Su sesión expiró.";
            return View(nameof(Login));
        }

        public IActionResult EditarUsuario(int IdUsuario)
        {
            if (HttpContext.Session.GetString("Logueo") == "Si")
            {
                ViewData["TipoDocumento"] = new SelectList(_context.Documento, "IdDocumento", "Tipo");
                ViewData["TipoRol"] = new SelectList(_context.Rol, "IdRol", "Nombre");
                RegistroModel model = new RegistroModel();
                model.oUsuario = _context.Usuario.Find(IdUsuario);
                model.oPersona = _context.Persona.Find(model.oUsuario.IdPersonaFk);
                return View(model);
            }
            ViewData["MensajeError"] = "Su sesión expiró.";
            return View(nameof(Login));
        }
        public IActionResult Prueba()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditaUsuario(RegistroModel registroModel)
        {
            _context.Update(registroModel.oPersona);
            await _context.SaveChangesAsync();
            registroModel.oUsuario.IdPersonaFk = registroModel.oPersona.IdPersona;
            _context.Update(registroModel.oUsuario);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(ConsultaUsuario));
        }
    }
}