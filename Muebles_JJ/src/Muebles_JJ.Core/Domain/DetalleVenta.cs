using System;
using System.Collections.Generic;

namespace Muebles_JJ.Infrastructure
{
    public partial class DetalleVenta
    {
        public int IdDetalle { get; set; }
        public int? IdVentaFk { get; set; }
        public int? IdProductoFk { get; set; }
        public int? Cantidad { get; set; }
        public decimal? ValorUnitario { get; set; }

        public virtual Producto IdProductoFkNavigation { get; set; }
        public virtual Venta IdVentaFkNavigation { get; set; }
    }
}
