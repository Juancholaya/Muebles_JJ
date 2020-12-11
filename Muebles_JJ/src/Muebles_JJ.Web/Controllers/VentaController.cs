using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Muebles_JJ.Infrastructure.Data;
using Muebles_JJ.Infrastructure;
using Muebles_JJ.Web.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Http;

namespace Muebles_JJ.Web.Controllers
{
    public class VentaController : Controller
    {
        private readonly Muebles_JJDbContext _context;

        public VentaController(Muebles_JJDbContext context)
        {
            _context = context;
        }

        //GET: Venta
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

        public IActionResult Create()
        {
            if (HttpContext.Session.GetString("Logueo") != "Si")
            {
                HttpContext.Session.SetString("MensajeError", "Su sesión expiró.");
                return RedirectToAction("Login", "Home");
            }
            ViewData["TipoDocumento"] = new SelectList(_context.Documento, "IdDocumento", "Tipo");
            VentaModel model = new VentaModel();
            model.editVenta = 0;
            return View(model);
        }

        public IActionResult CreateVenta(int IdVenta, int editVenta)
        {
            if (HttpContext.Session.GetString("Logueo") != "Si")
            {
                HttpContext.Session.SetString("MensajeError", "Su sesión expiró.");
                return RedirectToAction("Login", "Home");
            }
            ViewData["MensajeError"] = HttpContext.Session.GetString("MensajeError");
            ViewData["TipoDocumento"] = new SelectList(_context.Documento, "IdDocumento", "Tipo");
            VentaModel model = new VentaModel();
            model.editVenta = editVenta;
            model.oVenta = _context.Venta.Find(IdVenta);
            model.listArticulos = (from a in _context.Venta
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

            foreach (var item in model.listArticulos)
            {
                decimal valor = item.ValorUnidad ?? 0;
                decimal valor2 = (decimal)item.Cantidad;
                item.ValorTotal = valor * valor2;
                model.ValorTotal += item.ValorTotal;
            }
            return View("Create", model);
        }
        public IActionResult Inicial()
        {
            if (HttpContext.Session.GetString("Logueo") != "Si")
            {
                HttpContext.Session.SetString("MensajeError", "Su sesión expiró.");
                return RedirectToAction("Login", "Home");
            }
            return RedirectToAction("Inicial", "Home");
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AgregarProducto(VentaModel model)
        {
            if (HttpContext.Session.GetString("Logueo") != "Si")
            {
                HttpContext.Session.SetString("MensajeError", "Su sesión expiró.");
                return RedirectToAction("Login", "Home");
            }
            if (model.oVenta.IdVenta == 0)
            {
                model.oVenta.FechaVenta = DateTime.Now;
                _context.Add(model.oVenta);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(CreateArticulo), new { IdVenta = model.oVenta.IdVenta, editVenta = model.editVenta });
        }


        public IActionResult CreateArticulo(int IdVenta, int editVenta)
        {
            if (HttpContext.Session.GetString("Logueo") != "Si")
            {
                HttpContext.Session.SetString("MensajeError", "Su sesión expiró.");
                return RedirectToAction("Login", "Home");
            }
            ViewData["Tipo"] = new SelectList(_context.TipoProducto, "IdTipo", "Nombre");
            ViewData["Material"] = new SelectList(_context.MaterialProducto, "IdMaterial", "Nombre");
            ViewData["Color"] = new SelectList(_context.ColorProducto, "IdColor", "Nombre");
            ViewData["Medida"] = new SelectList(_context.MedidaProducto, "IdMedida", "CantidadCentimetros");
            VentaModel model = new VentaModel();
            model.editVenta = editVenta;
            model.oDetalleVenta.IdVentaFk = IdVenta;
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AgregarArticulo(VentaModel model)
        {
            if (HttpContext.Session.GetString("Logueo") != "Si")
            {
                HttpContext.Session.SetString("MensajeError", "Su sesión expiró.");
                return RedirectToAction("Login", "Home");
            }
            int idproducto = _context.Producto.Where(x => x.IdTipoFk == model.oProducto.IdTipoFk
                                                       && x.IdMaterialFk == model.oProducto.IdMaterialFk
                                                       && x.IdColorFk == model.oProducto.IdColorFk
                                                       && x.IdMedidaFk == model.oProducto.IdMedidaFk).Select(x => x.IdProducto).FirstOrDefault();
            if (idproducto != 0)
            {
                model.oDetalleVenta.IdProductoFk = idproducto;
                _context.Add(model.oDetalleVenta);
                await _context.SaveChangesAsync();
                HttpContext.Session.SetString("MensajeError", "");
            }
            else
                HttpContext.Session.SetString("MensajeError", "Producto no existente.");
            return RedirectToAction(nameof(CreateVenta), new { IdVenta = model.oDetalleVenta.IdVentaFk, editVenta = model.editVenta });
        }
        public async Task<IActionResult> EliminarArticulo(int IdDetalleVenta, int idVenta, int editVenta)
        {
            if (HttpContext.Session.GetString("Logueo") != "Si")
            {
                HttpContext.Session.SetString("MensajeError", "Su sesión expiró.");
                return RedirectToAction("Login", "Home");
            }
            DetalleVenta model = await _context.DetalleVenta.FindAsync(IdDetalleVenta);
            _context.DetalleVenta.Remove(model);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(CreateVenta), new { IdVenta = idVenta, editVenta = editVenta });
        }
        public async Task<IActionResult> EliminarVenta(int IdVenta, int editVenta)
        {
            if (HttpContext.Session.GetString("Logueo") != "Si")
            {
                HttpContext.Session.SetString("MensajeError", "Su sesión expiró.");
                return RedirectToAction("Login", "Home");
            }
            if (editVenta == 0 && IdVenta != 0)
            {
                List<DetalleVenta> listDetalleVenta = _context.DetalleVenta.Where(x => x.IdVentaFk == IdVenta).ToList();
                foreach (var item in listDetalleVenta)
                {
                    _context.DetalleVenta.Remove(item);
                }
                Venta venta = await _context.Venta.FindAsync(IdVenta);
                _context.Venta.Remove(venta);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
