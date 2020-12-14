using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Muebles_JJ.Infrastructure;

namespace Muebles_JJ.Web.Models
{
    public class InsumoModel
    {
        public InsumoModel()
        {
            oInsumo = new Insumo();
            oUnidadMedida = new Unidadmedida();
        }
        public Insumo oInsumo { get; set; }

        public Unidadmedida oUnidadMedida { get; set; }
    }
}
