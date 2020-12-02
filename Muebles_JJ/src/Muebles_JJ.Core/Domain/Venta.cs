using System;
using System.Collections.Generic;

namespace Muebles_JJ.Infrastructure
{
    public partial class Venta
    {
        public Venta()
        {
            ComprobantePago = new HashSet<ComprobantePago>();
            Pedido = new HashSet<Pedido>();
        }

        public int IdVenta { get; set; }
        public DateTime? Fecha { get; set; }
        public int? CantidadProducto { get; set; }
        public int? SubTotal { get; set; }
        public int? Total { get; set; }
        public int? IdProductoFk { get; set; }

        public virtual Producto IdProductoFkNavigation { get; set; }
        public virtual ICollection<ComprobantePago> ComprobantePago { get; set; }
        public virtual ICollection<Pedido> Pedido { get; set; }
    }
}
