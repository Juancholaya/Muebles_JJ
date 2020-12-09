using System;
using System.Collections.Generic;

namespace Muebles_JJ.Infrastructure
{
    public partial class Unidadmedida
    {
        public Unidadmedida()
        {
            Insumo = new HashSet<Insumo>();
        }

        public int IdMedida { get; set; }
        public string NombreLargo { get; set; }
        public string NombreCorto { get; set; }

        public virtual ICollection<Insumo> Insumo { get; set; }
    }
}
