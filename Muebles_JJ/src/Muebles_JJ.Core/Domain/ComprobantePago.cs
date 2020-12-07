using System;
using System.Collections.Generic;

namespace Muebles_JJ.Infrastructure
{
    public partial class Documento
    {
        public int IdComprobante { get; set; }
        public DateTime? Fecha { get; set; }
        public int? IdVentaFk { get; set; }

        public virtual Venta IdVentaFkNavigation { get; set; }
    }
}
