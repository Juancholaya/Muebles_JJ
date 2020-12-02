using System;
using System.Collections.Generic;

namespace Muebles_JJ.Infrastructure
{
    public partial class Producto
    {
        public Producto()
        {
            Inventario = new HashSet<Inventario>();
            Venta = new HashSet<Venta>();
        }

        public int IdProducto { get; set; }
        public int? IdTipoFk { get; set; }
        public int? IdMaterialFk { get; set; }
        public int? IdColorFk { get; set; }
        public int? IdMedidaFk { get; set; }

        public virtual ColorProducto IdColorFkNavigation { get; set; }
        public virtual MaterialProducto IdMaterialFkNavigation { get; set; }
        public virtual MedidaProducto IdMedidaFkNavigation { get; set; }
        public virtual TipoProducto IdTipoFkNavigation { get; set; }
        public virtual ICollection<Inventario> Inventario { get; set; }
        public virtual ICollection<Venta> Venta { get; set; }
    }
}
