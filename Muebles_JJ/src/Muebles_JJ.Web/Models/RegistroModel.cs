using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Muebles_JJ.Infrastructure;

namespace Muebles_JJ.Web.Models
{
    public class RegistroModel
    {
        public RegistroModel()
        {
            oPersona = new Persona();
            oUsuario = new Usuario();
        }
        public Persona oPersona { get; set; }

        public Usuario oUsuario { get; set; }
    }
}
