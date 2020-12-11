using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Web;

namespace Muebles_JJ.Web.Models
{
    public class ITextEvents : PdfPageEventHelper
    {
        private PdfContentByte cb;

        private PdfTemplate headerTemplate, footerTemplate;

        private BaseFont bf = null;

        private BaseFont bf2 = null;

        private DateTime PrintTime = DateTime.Now;

        #region Fields
        private string _header;
        #endregion

        #region Properties
        public string Header
        {
            get { return _header; }
            set { _header = value; }
        }
        #endregion


        public override void OnOpenDocument(PdfWriter writer, Document document)
        {
            PrintTime = DateTime.Now;
            bf = BaseFont.CreateFont(BaseFont.HELVETICA_BOLD, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            bf2 = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            cb = writer.DirectContent;
            headerTemplate = cb.CreateTemplate(100, 100);
            footerTemplate = cb.CreateTemplate(50, 50);
        }

        public override void OnEndPage(iTextSharp.text.pdf.PdfWriter writer, iTextSharp.text.Document document)
        {
            base.OnEndPage(writer, document);

            iTextSharp.text.Font baseFontNormal = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 3f, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK);

            iTextSharp.text.Font baseFontBig = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 5f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK);

            PdfPTable pdfTab = new PdfPTable(3);

            PdfPCell pdfCell1 = new PdfPCell();
            PdfPCell pdfCell3 = new PdfPCell();

            pdfCell1.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfCell3.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfCell3.VerticalAlignment = Element.ALIGN_MIDDLE;


            pdfCell1.Border = 0;
            pdfCell3.Border = 0;

            pdfTab.AddCell(pdfCell1);
            pdfTab.AddCell(pdfCell3);

            pdfTab.TotalWidth = document.PageSize.Width - 80f;
            pdfTab.WidthPercentage = 70;



            pdfTab.WriteSelectedRows(0, -1, -400, document.PageSize.Height - 350, writer.DirectContent);


            cb.MoveTo(40, document.PageSize.GetBottom(30));
            cb.LineTo(document.PageSize.Width - 40, document.PageSize.GetBottom(30));
            cb.Stroke();
        }

        public override void OnCloseDocument(PdfWriter writer, Document document)
        {
            base.OnCloseDocument(writer, document);
        }
    }
}