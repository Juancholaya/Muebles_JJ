using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Muebles_JJ.Infrastructure;

namespace Muebles_JJ.Web.Models
{
    public class VentaModel
    {
        public VentaModel()
        {
            oVenta = new Venta();
            listArticulos = new List<Articulo>();
            oProducto = new Producto();
            oDetalleVenta = new DetalleVenta();
        }

        public decimal ValorTotal { get; set; }
        public int editVenta { get; set; }

        public Venta oVenta { get; set; }
        public List<Articulo> listArticulos { get; set; }
        public Producto oProducto { get; set; }
        public DetalleVenta oDetalleVenta { get; set; }
    }
}
