using Muebles_JJ.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Muebles_JJ.Infrastructure;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;

namespace Muebles_JJ.Web.Models
{
    public class GenerarFactura
    {
        private readonly Muebles_JJDbContext _context;

        public GenerarFactura(Muebles_JJDbContext context)
        {
            _context = context;
        }
        public byte[] GeneraPDF(int IdVenta)
        {
            byte[] Pdf = null;
            List<Articulo> listaProducto = (from a in _context.Venta
                                    join b in _context.DetalleVenta on a.IdVenta equals b.IdVentaFk
                                    join c in _context.Producto on b.IdProductoFk equals c.IdProducto
                                    join d in _context.TipoProducto on c.IdTipoFk equals d.IdTipo
                                    join e in _context.MaterialProducto on c.IdMaterialFk equals e.IdMaterial
                                    join f in _context.ColorProducto on c.IdColorFk equals f.IdColor
                                    join g in _context.MedidaProducto on c.IdMedidaFk equals g.IdMedida
                                    where a.IdVenta == IdVenta
                                    select new Articulo
                                    {
                                        IDDetalle = b.IdDetalle,
                                        Tipo = d.Nombre,
                                        Material = e.Nombre,
                                        Color = f.Nombre,
                                        Medida = g.CantidadCentimetros,
                                        Cantidad = b.Cantidad,
                                        ValorUnidad = b.ValorUnitario
                                    }).ToList();

            string tr = @"<tr>
                            <td>{0}</td>
                            <td>{1}</td>
                            <td>{2}</td>
                            <td>{3}</td>
                            <td>{4}</td>
                            <td>{5}</td>
                            <td>{6}</td>
                        </tr>";
            string registro = string.Empty;
            decimal ValorTotal = 0;
            foreach (var item in listaProducto)
            {
                decimal valor = item.ValorUnidad ?? 0;
                decimal valor2 = (decimal)item.Cantidad;
                item.ValorTotal = valor * valor2;
                ValorTotal += item.ValorTotal;
                registro += string.Format(tr, item.Tipo, item.Material, item.Color, item.Medida, item.Cantidad, item.ValorUnidad, item.ValorTotal);
            }
            string table = string.Format("<table style='font-size:small' id='tableProductos' class='table'> <thead> <tr> <th>Tipo</th> <th>Material</th> <th>Color</th> <th>Medida(cm)</th> <th>Cantidad</th> <th>Valor Unitario</th> <th>Valor Total</th> </tr></thead> <tbody>{0}</tbody> </table>", registro);
            string html = "<html><head> <meta charset='utf-8'/><link rel='stylesheet' href='https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css'/> <script src='https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js'></script> <script src='https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js'></script> <script src='https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js'></script></head><body><div class='container'> <div class='row'> <div class='col-2'></div><div class='col-8'> <div class='row'> <div class='col-3'> <img src='https://localhost:44379/Imagenes/logo.jpeg' width='50' height='50'/> </div><div class='col-5'> <h1 style='text-align:center'>Muebles JJ</h1> </div><div class='col-4'> <br/> <p style='text-align:center; color:red;'>Comprobante de Pago 1</p></div></div><br/> <div class='row'> <div class='col-6'> <p><b>Nombre Cliente:</b>{0}</p></div><div class='col-6'> <p><b>Documento Cliente:</b>{1}</p></div></div><div class='row'> <div class='col-6'> <p><b>Fecha Venta:</b>{2}</p></div><div class='col-6'> <p><b>Fecha Entrega:</b>{3}</p></div></div><br/> <div class='row'> <div class='col-12'>{4}</div></div><hr/> <div class='row'> <div class='col-6'></div><div class='col-3'><b>Total Venta</b></div><div class='col-3'>{5}</div></div><div class='col-2'></div></div></div></div></body></html>";
            Venta venta = _context.Venta.Find(IdVenta);
            html = string.Format(html, venta.NombreCliente, venta.DocumentoCliente, venta.FechaVenta, venta.FechaEntrega, table, ValorTotal);

            using (var memoryStream = new MemoryStream())
            {
                var document = new Document(PageSize.LETTER, 50, 10, 50, 50);
                var writer = PdfWriter.GetInstance(document, memoryStream);

                writer.PageEvent = new ITextEvents();

                document.Open();

                using (var cssMemoryStream = new MemoryStream(System.Text.Encoding.UTF8.GetBytes("body{background-color:white;}")))
                {
                    using (var htmlMemoryStream = new MemoryStream(System.Text.Encoding.UTF8.GetBytes(html)))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, document, htmlMemoryStream, cssMemoryStream);
                    }
                }
                document.Close();
                Pdf = memoryStream.ToArray();
            }
            return Pdf;
        }
    }
}
