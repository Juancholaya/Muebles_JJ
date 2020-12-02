using System;
using System.Collections.Generic;

namespace Muebles_JJ.Infrastructure
{
    public partial class Persona
    {
        public Persona()
        {
            Usuario = new HashSet<Usuario>();
        }

        public int IdPersona { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string Direccion { get; set; }
        public int? IdDocumentoFk { get; set; }

        public virtual Documento IdDocumentoFkNavigation { get; set; }
        public virtual ICollection<Usuario> Usuario { get; set; }
    }
}
