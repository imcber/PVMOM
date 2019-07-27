using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Diagnostics;

namespace Punto_de_Venta
{
    public partial class Cobrar : Form
    {
        double total = 0;
        double totalD = 0;
        public static double totalT = 0;
        connectMySql con = new connectMySql();
        PuntoDeVenta fr = new PuntoDeVenta();
        bool descuento = false;
        List<List<string>> ventas = new List<List<string>>();
        public Cobrar()
        {
            fr.Owner = this;
            con.conection();
            total = PuntoDeVenta.total;
            ventas = PuntoDeVenta.productoV; //codigo, nombre, precio, id, cantidad, cantidadComprar
            InitializeComponent();
            descuento = false;
        }

        private void Cobrar_Load(object sender, EventArgs e)
        {

            lbDescuento.Visible = false;
            lbTotalDescuento.Visible = false;
            totalD = total * .85;
            CancelButton = button2;
            button2.Text = "&Cancelar";
            label1.Text = "$" + total;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(descuento)
                cobro(totalD);
            else
            {
                cobro(total);
            }
        }

        private void cobro(double totalH) {
            double cambio = 0, pago = float.Parse(txtPago.Text);
            DialogResult result;

            if (totalH > 0)
            {
                
                result = MessageBox.Show("Seguro quiere cobrar $" + totalH + " con $" + pago, "Total", MessageBoxButtons.YesNo);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    if (pago >= totalH)
                    {
                        result = MessageBox.Show("¿Quiere imprimir ticket?", "Ticket", MessageBoxButtons.YesNo);
                        if (result == System.Windows.Forms.DialogResult.Yes)
                        {
                            crearTicket(totalH);
                        }
                        guardarTotal(totalH);
                        cambio = pago - totalH;
                        MessageBox.Show("El cambio es de: $" + cambio, "Cambio", MessageBoxButtons.OK);
                        altaDeVentas();
                        PuntoDeVenta.ventas.Clear();
                        PuntoDeVenta.band = true;
                        fr.Refresh();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("El monto no es suficiente para pagar", "Error", MessageBoxButtons.OK);
                    }
                }
            }
            else
                MessageBox.Show("No puedes vender $0 pesos", "Error", MessageBoxButtons.OK);
        }

        private void guardarTotal(double totalH) {
            totalT += totalH;
            Properties.Settings.Default.VentaDia = totalT;
            Properties.Settings.Default.Save();
        }
        private void altaDeVentas()
        {//codigo, nombre, precio, id, cantidad, cantidadComprar
            for (int i = 0; i < ventas.Count(); i++) {
                con.altaVentas(ventas[i][0],ventas[i][1],ventas[i][2], ventas[i][5]);
                con.updateCantidad(ventas[i][3], ventas[i][4], ventas[i][5]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override bool ProcessCmdKey(ref System.Windows.Forms.Message msg, System.Windows.Forms.Keys keyData)
        {

            if ((keyData != Keys.Enter))
                return base.ProcessCmdKey(ref msg, keyData);

            if (descuento)
                cobro(totalD);
            else
            {
                cobro(total);
            }
            
            return true;
        }

        private void crearTicket(double totalH)
        {
            float myWidth = 300f;
            float myHeight = 600f;
            var pgSize = new iTextSharp.text.Rectangle(myWidth, myHeight);
            var doc = new iTextSharp.text.Document(pgSize,5,0,5,0);
            PdfWriter writer = PdfWriter.GetInstance(doc,
                            new FileStream(@"C:\ticket\ticket.pdf", FileMode.Create));
            doc.AddTitle("Ticket Compra");
            doc.Open();
            iTextSharp.text.Font _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
            doc.Add(new Paragraph("Papeleria Maxy"));

            //agregando una imagen
            iTextSharp.text.Image imagen = iTextSharp.text.Image.GetInstance(@"C:\Ticket\logo.png");
            imagen.BorderWidth = 0;
            imagen.Alignment = Element.ALIGN_RIGHT;
            float percentage = 0.0f;
            percentage = 150 / imagen.Width;
            imagen.ScalePercent(percentage * 100);

            doc.Add(new Paragraph("Ticket de compra"));
            doc.Add(new Paragraph(DateTime.Now.ToString("G")));
            PdfPTable tblPrueba = new PdfPTable(3);
            tblPrueba.WidthPercentage = 100;

            PdfPCell clProducto = new PdfPCell(new Phrase("Producto", _standardFont));
            clProducto.BorderWidth = 0;
            clProducto.BorderWidthBottom = 0.5f;

            PdfPCell clCantidad = new PdfPCell(new Phrase("Cantidad", _standardFont));
            clCantidad.BorderWidth = 0;
            clCantidad.BorderWidthBottom = 0.5f;

            PdfPCell clPrecio = new PdfPCell(new Phrase("Precio", _standardFont));
            clPrecio.BorderWidth = 0;
            clPrecio.BorderWidthBottom = 1.5f;

            tblPrueba.AddCell(clProducto);
            tblPrueba.AddCell(clCantidad);
            tblPrueba.AddCell(clPrecio);

            for (int i = 0; i < ventas.Count(); i++)
            {
                clProducto = new PdfPCell(new Phrase(ventas[i][1], _standardFont));
                clProducto.BorderWidth = 0;

                clCantidad = new PdfPCell(new Phrase(ventas[i][5], _standardFont));
                clCantidad.BorderWidth = 0;

                clPrecio = new PdfPCell(new Phrase(ventas[i][2], _standardFont));
                clPrecio.BorderWidth = 0;

                tblPrueba.AddCell(clProducto);
                tblPrueba.AddCell(clCantidad);
                tblPrueba.AddCell(clPrecio);
            }
            doc.Add(tblPrueba);

            doc.Add(new Paragraph("Total: " + totalH));

            doc.Close();
            writer.Close();
            try
            {
                string pdfPath = Path.Combine(Application.StartupPath, @"C:\ticket\ticket.pdf");
                Process.Start(pdfPath);
            }
            catch (Exception e) {
                MessageBox.Show("Cierra el ticket anterior", "Error", MessageBoxButtons.OK);
                crearTicket(totalH);
            }


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double d;
            descuento = true;
            d = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("Cuanto descuento se aplicara?", "Descuento", "1", 0, 0));
            lbDescuento.Text = "-" + d + "%"; 
            d = 100 - d;
            d = d * .01;
            totalD = total * d;
            lbTotalDescuento.Text ="" + totalD;

            lbDescuento.Visible = true;
            lbTotalDescuento.Visible = true;

        }

       
       
    }
}
    