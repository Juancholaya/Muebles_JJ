using System;
using System.Collections.Generic;

namespace Muebles_JJ.Infrastructure
{
    public partial class Venta
    {
        public Venta()
        {
            ComprobantePago = new HashSet<ComprobantePago>();
            DetalleVenta = new HashSet<DetalleVenta>();
            Pedido = new HashSet<Pedido>();
        }

        public int IdVenta { get; set; }
        public string DocumentoCliente { get; set; }
        public int? IdDocumentoFk { get; set; }
        public string NombreCliente { get; set; }
        public DateTime? FechaVenta { get; set; }
        public DateTime? FechaEntrega { get; set; }
        public int? Entrega { get; set; }

        public virtual Documento IdDocumentoFkNavigation { get; set; }
        public virtual ICollection<ComprobantePago> ComprobantePago { get; set; }
        public virtual ICollection<DetalleVenta> DetalleVenta { get; set; }
        public virtual ICollection<Pedido> Pedido { get; set; }
    }
}
