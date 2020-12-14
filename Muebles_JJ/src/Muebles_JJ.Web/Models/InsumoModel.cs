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
            listUnidadmedida = new List<Unidadmedida>();
            listInsumo = new List<Insumo>();
        }
        public Insumo oInsumo { get; set; }
        public List<Unidadmedida> listUnidadmedida { get; set; }
        public List<Insumo> listInsumo { get; set; }
    }
}
