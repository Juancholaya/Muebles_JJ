using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Muebles_JJ.Infrastructure.Data;

namespace Muebles_JJ.Web.Controllers
{
    public class ColorProductoController : Controller
    {
        private readonly Muebles_JJDbContext _context;

        public ColorProductoController(Muebles_JJDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var listado = await _context.ColorProducto.ToListAsync();
            return View(listado);
        }
    }
}
