using System;
using System.Collections.Generic;

namespace Muebles_JJ.Infrastructure
{
    public partial class ComprobantePago
    {
        public int IdComprobante { get; set; }
        public DateTime? Fecha { get; set; }
        public int? IdVentaFk { get; set; }

        public virtual Venta IdVentaFkNavigation { get; set; }
    }
}
