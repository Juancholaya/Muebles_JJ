namespace Muebles_JJ.Web.Models
{
    public class Articulo
    {
        public int IDDetalle { get; set; }
        public string Tipo { get; set; }
        public string Material { get; set; }
        public string Color { get; set; }
        public int? Medida { get; set; }
        public int? Cantidad { get; set; }
        public decimal? ValorUnidad { get; set; }
        public decimal ValorTotal { get; set; }
    }
}
