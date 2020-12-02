using System;
using System.Collections.Generic;

namespace Muebles_JJ.Infrastructure
{
    public partial class MedidaProducto
    {
        public MedidaProducto()
        {
            Producto = new HashSet<Producto>();
        }

        public int IdMedida { get; set; }
        public int? CantidadCentimetros { get; set; }

        public virtual ICollection<Producto> Producto { get; set; }
    }
}
