using System;
using System.Collections.Generic;

namespace Muebles_JJ.Infrastructure
{
    public partial class Inventario
    {
        public int IdInventario { get; set; }
        public DateTime? FechaEntrada { get; set; }
        public DateTime? FechaSalida { get; set; }
        public int? IdInsumoFk { get; set; }
        public int? IdProductoFk { get; set; }

        public virtual Insumo IdInsumoFkNavigation { get; set; }
        public virtual Producto IdProductoFkNavigation { get; set; }
    }
}
