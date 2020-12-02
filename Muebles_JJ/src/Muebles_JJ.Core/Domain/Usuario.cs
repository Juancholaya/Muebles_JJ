using System;
using System.Collections.Generic;

namespace Muebles_JJ.Infrastructure
{
    public partial class Usuario
    {
        public Usuario()
        {
            Telefono = new HashSet<Telefono>();
        }

        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string ContraseñaUsuario { get; set; }
        public int? IdPersonaFk { get; set; }
        public int? IdRolFk { get; set; }

        public virtual Persona IdPersonaFkNavigation { get; set; }
        public virtual Rol IdRolFkNavigation { get; set; }
        public virtual ICollection<Telefono> Telefono { get; set; }
    }
}
