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
        public IActionResult GenerarFicha(int IdVenta)
        {
            if (HttpContext.Session.GetString("Logueo") != "Si")
            {
                HttpContext.Session.SetString("MensajeError", "Su sesión expiró.");
                return RedirectToAction("Login", "Home");
            }
            List<Articulo> model = (from a in _context.Venta
                                    join b in _context.DetalleVenta on a.IdVenta equals b.IdVentaFk
                                    join c in _context.Producto on b.IdProductoFk equals c.IdProducto
                                    join d in _context.TipoProducto on c.IdTipoFk equals d.IdTipo
                                    join e in _context.MaterialProducto on c.IdMaterialFk equals e.IdMaterial
                                    join f in _context.ColorProducto on c.IdColorFk equals f.IdColor
                                    join g in _context.MedidaProducto on c.IdMedidaFk equals g.IdMedida
                                    where a.IdVenta == IdVenta
                                    select new Articulo
                                    {
                                        IDDetalle = b.IdDetalle,
                                        Tipo = d.Nombre,
                                        Material = e.Nombre,
                                        Color = f.Nombre,
                                        Medida = g.CantidadCentimetros,
                                        Cantidad = b.Cantidad,
                                        ValorUnidad = b.ValorUnitario
                                    }).ToList();
            return View(model);
        }        
    }
}