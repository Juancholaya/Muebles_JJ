using System;
using System.Collections.Generic;

namespace Muebles_JJ.Infrastructure
{
    public partial class CantidadInsumo
    {
        public CantidadInsumo()
        {
            Insumo = new HashSet<Insumo>();
        }

        public int IdCantidad { get; set; }
        public string Tipo { get; set; }
        public int? Cantidad { get; set; }

        public virtual ICollection<Insumo> Insumo { get; set; }
    }
}
