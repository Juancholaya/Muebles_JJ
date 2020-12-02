using System;
using System.Collections.Generic;

namespace Muebles_JJ.Infrastructure
{
    public partial class Insumo
    {
        public Insumo()
        {
            Inventario = new HashSet<Inventario>();
        }

        public int IdInsumo { get; set; }
        public string Nombre { get; set; }
        public int? IdCantidadFk { get; set; }

        public virtual CantidadInsumo IdCantidadFkNavigation { get; set; }
        public virtual ICollection<Inventario> Inventario { get; set; }
    }
}
