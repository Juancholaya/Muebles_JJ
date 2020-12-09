using System;
using System.Collections.Generic;

namespace Muebles_JJ.Infrastructure
{
    public partial class Documento
    {
        public Documento()
        {
            Persona = new HashSet<Persona>();
            Venta = new HashSet<Venta>();
        }

        public int IdDocumento { get; set; }
        public string Tipo { get; set; }

        public virtual ICollection<Persona> Persona { get; set; }
        public virtual ICollection<Venta> Venta { get; set; }
    }
}
