using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto_de_Venta
{
    public partial class PuntoDeVenta : Form
    {
        connectMySql con = new connectMySql();
        public static double total = 0;
        public static bool band = false;
        int num = 1;
        public static List<List<string>> ventas = new List<List<string>>();
        List<float> listUltimoPrecio = new List<float>();
        public static List<List<string>> productoV = new List<List<string>>();

        public PuntoDeVenta()
        {
            InitializeComponent();
            con.conection();
            DataTable table = new DataTable();

        }

        private void PuntoDeVenta_Resize(object sender, EventArgs e)
        {

        }


        private static bool isValid(String str)
        {
            return Regex.IsMatch(str, @"^[0-9]*\.?[0-9]*$");
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            Cobrar fr = new Cobrar();
            fr.Owner = this;
            fr.Show();


        }

        public void btnLimpiar_Click(object sender, EventArgs e)
        {
            cleanFlds();
            productoV.Clear();
        }

        private void cleanFlds()
        {
            lbCantidad.Items.Clear();
            //txtCodigo.Clear();
            lbProducto.Items.Clear();
            lbPrecio.Items.Clear();
            lbProducto.Items.Clear();
            lbPrecioTotal.Items.Clear();
            lbNumero.Items.Clear();
            txtTotalVenta.Clear();
            num = 1;
            total = 0;
            ventas.Clear();
            
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEliminarUltimo_Click(object sender, EventArgs e)
        {

        }

        private void PuntoDeVenta_Activated(object sender, EventArgs e)
        {
            if (band)
            {
                lbCantidad.Items.Clear();
                productoV.Clear();
                //txtCodigo.Clear();
                lbProducto.Items.Clear();
                lbPrecio.Items.Clear();
                lbProducto.Items.Clear();
                lbPrecioTotal.Items.Clear();
                lbNumero.Items.Clear();
                txtTotalVenta.Clear();
                num = 1;
                total = 0;
                ventas.Clear();
                band = false;
            }
        }

        private void txtNombreP_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                dgProducto.DataSource = con.busquedaM(txtNombreP.Text);
                dgProducto.Columns.Remove("codigo");
                //dgProducto.Columns.Remove("cantidad");
                //dgProducto.Columns.Remove("idproducto");
                dgProducto.Columns[0].Width = 50;
                dgProducto.Columns[1].Width = 200;
                dgProducto.Columns[2].Width = 50;
                dgProducto.Columns[3].Width = 50;
            }
            catch (Exception es)
            {
                Console.WriteLine("Error:" + es);
            }

        }

        private void dgProducto_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            List<string> producto = new List<string>();
            string n = "0";
            //dgProducto.CurrentRow.Cells[]
            producto = con.busqueda(dgProducto.CurrentRow.Cells[0].Value.ToString(), false);
            if (producto.Count() > 0)
            {
                if (!producto[2].Equals("ERROR"))
                {
                    n = Microsoft.VisualBasic.Interaction.InputBox("Cantidad de " + producto[1], "Producto", "1", 0, 0);

                    if (n.Length > 0 && isValid(n))
                    {
                        producto.Add(n.ToString());
                        productoV.Add(producto);
                        pintaGrid();
                    }
                    txtNombreP.Clear();
                }
                else
                {
                    MessageBox.Show("ERROR EN EL PRODUCTO.");
                }

            }
        }

        private void pintaGrid()
        {
            cleanFlds();
            int cont = 0;
            List<string> producto = new List<string>();
            double aux = 0.0;
            total = 0;
            while (cont < productoV.Count())
            {
                producto = productoV[cont];

                lbNumero.Items.Add(cont);
                lbCantidad.Items.Add(producto[5]);
                lbProducto.Items.Add(producto[1]);
                lbPrecio.Items.Add("$" + producto[2]);
                aux = double.Parse(producto[2]) * double.Parse(producto[5]);
                lbPrecioTotal.Items.Add(aux);
                cont++;
                total += aux;
            }

            txtTotalVenta.Text = "$" + total;
        }

        private void ventaDeDiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string pass;
            pass = Microsoft.VisualBasic.Interaction.InputBox("Escriba contraseña", "Contraeña", "123456", 0, 0);

        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ventaDelDiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string pass;
            pass = Microsoft.VisualBasic.Interaction.InputBox("Escriba contraseña", "Contraeña", "123456", 0, 0);
            if (pass == Properties.Settings.Default.password)
            {
                List<List<string>> producto = new List<List<string>>();
                producto = con.busquedaVentasDelDia("init", "init");
                int indx = 0;
                double cantidad = 0;
                double precio = 0;
                double precioDia = 0;

                while(indx < producto.Count)
                {
                    precio = double.Parse(producto[indx][0]);
                    cantidad = double.Parse(producto[indx][1]);
                    precioDia += (precio * cantidad);
                    indx++;
                }

                MessageBox.Show("Tu venta del dia de hoy es de "+ precioDia, "Venta del dia", MessageBoxButtons.OK);

            }
        }

        private void reiniciarVentaDelDíaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string pass;
            pass = Microsoft.VisualBasic.Interaction.InputBox("Escriba contraseña", "Contraeña", "123456", 0, 0);
            if (pass == Properties.Settings.Default.password)
            {
                Properties.Settings.Default.VentaDia = 0;
                Properties.Settings.Default.Save();
            }
            MessageBox.Show("La venta ha sido reiniciada", "Venta del dia", MessageBoxButtons.OK);

        }

        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string pass, passN;
            pass = Microsoft.VisualBasic.Interaction.InputBox("Escriba contraseña", "Contraeña", "123456", 0, 0);
            if (pass == Properties.Settings.Default.password)
            {
                passN = Microsoft.VisualBasic.Interaction.InputBox("Escriba nueva contraseña", "Contraeña", "123456", 0, 0);
                Properties.Settings.Default.password = passN;
                Properties.Settings.Default.Save();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string n = Microsoft.VisualBasic.Interaction.InputBox("Cantidad de ", "Producto", "1", 0, 0);

            if (n.Length > 0 && isValid(n))
            {
                MessageBox.Show("Chido");
            }
        }

        private void ventasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Ventas vt = new Ventas();
            vt.Show();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Producto fr = new Producto();
            fr.Show();
        }

        private void lbProducto_DoubleClick(object sender, EventArgs e)
        {

            if (productoV.Count > 0 && lbProducto.SelectedItem != null)
            {
                String curItem = lbProducto.SelectedItem.ToString();
                int curIdx = lbProducto.SelectedIndex;
                DialogResult result;

                result = MessageBox.Show("¿Deseas eliminar " + curItem + " de la cuenta?", "Eliminar", MessageBoxButtons.YesNo);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    productoV.RemoveAt(curIdx);
                    pintaGrid();
                }

            }

        }

        private void lbCantidad_DoubleClick(object sender, EventArgs e)
        {

            if (productoV.Count > 0 && lbCantidad.SelectedItem != null)
            {
                int curIdx = lbCantidad.SelectedIndex;
                String curItem = productoV[curIdx][1];
                DialogResult result;
                string n = "0";

                result = MessageBox.Show("¿Deseas editar la cantidad de " + curItem + " de la cuenta?", "Editar", MessageBoxButtons.YesNo);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    n = Microsoft.VisualBasic.Interaction.InputBox("Cantidad de " + curItem, "Producto", productoV[curIdx][5], 0, 0);
                    if (n.Length > 0 && isValid(n) && n != "0")
                    {
                        productoV[curIdx][5] = n;
                        pintaGrid();
                    }
                }

            }
        }

        private void lbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected override bool ProcessCmdKey(ref System.Windows.Forms.Message msg, System.Windows.Forms.Keys keyData)
        {

            if ((keyData != Keys.Enter))
                return base.ProcessCmdKey(ref msg, keyData);

            List<string> producto = new List<string>();
            string n = "0";
            if (dgProducto.Rows.Count > 0)
            {
                producto = con.busqueda(dgProducto.Rows[0].Cells[0].Value.ToString(), false);
                if (producto.Count() > 0)
                {
                    if (!producto[2].Equals("ERROR"))
                    {
                        n = Microsoft.VisualBasic.Interaction.InputBox("Cantidad de " + producto[1], "Producto", "1", 0, 0);

                        if (n.Length > 0 && isValid(n))
                        {
                            producto.Add(n.ToString());
                            productoV.Add(producto);
                            pintaGrid();
                        }
                        txtNombreP.Clear();
                    }
                    else
                    {
                        MessageBox.Show("ERROR EN EL PRODUCTO.");
                    }
                }
            }
            return true;
        }
    }
}
