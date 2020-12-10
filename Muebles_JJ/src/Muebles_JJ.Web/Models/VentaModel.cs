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

        public Venta oVenta { get; set; }
        public List<Articulo> listArticulos { get; set; }
        public Producto oProducto { get; set; }
        public DetalleVenta oDetalleVenta { get; set; }
    }

    public class Articulo
    {
        public int IDDetalle { get; set; }
        public string Tipo { get; set; }
        public string Material { get; set; }
        public string Color { get; set; }
        public int? Medida { get; set; }
        public int? Cantidad { get; set; }
        public decimal? ValorUnidad { get; set; }
        public decimal ValorTotal { get; set; }
    }
}
