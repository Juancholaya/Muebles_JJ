using System;
using System.Collections.Generic;

namespace Muebles_JJ.Infrastructure
{
    public partial class Documento
    {
        public Documento()
        {
            Persona = new HashSet<Persona>();
        }

        public int IdDocumento { get; set; }
        public string Tipo { get; set; }
        public long? Numero { get; set; }

        public virtual ICollection<Persona> Persona { get; set; }
    }
}
