using System;
using System.Collections.Generic;

namespace Muebles_JJ.Infrastructure
{
    public partial class Insumo
    {
        public int IdInsumo { get; set; }
        public string Nombre { get; set; }
        public int? IdMedidaFk { get; set; }
        public int? Cantidad { get; set; }

        public virtual Unidadmedida IdMedidaFkNavigation { get; set; }
    }
}
