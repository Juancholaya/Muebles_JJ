using System;
using System.Collections.Generic;

namespace Muebles_JJ.Infrastructure
{
    public partial class MaterialProducto
    {
        public MaterialProducto()
        {
            Producto = new HashSet<Producto>();
        }

        public int IdMaterial { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Producto> Producto { get; set; }
    }
}
