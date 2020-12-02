using System;
using System.Collections.Generic;

namespace Muebles_JJ.Infrastructure
{
    public partial class Pedido
    {
        public int IdPedido { get; set; }
        public DateTime? FechaEntrega { get; set; }
        public string DireccionEntrega { get; set; }
        public int? IdVentaFk { get; set; }

        public virtual Venta IdVentaFkNavigation { get; set; }
    }
}
