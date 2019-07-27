using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Text.RegularExpressions;

namespace Punto_de_Venta
{
    public partial class Producto : Form
    {

        connectMySql con = new connectMySql();
        int idProducto;
        Crud.WsPapeleriaClient metodo = new Crud.WsPapeleriaClient();
        List<string> producto = new List<string>();

        public Producto()
        {
            con.conection();
            InitializeComponent();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String codigo = txtCodigo.Text;
            string query;
            Properties.Settings.Default.Save();
            if (txtNombre.Text == "" || txtPrecio.Text == "" || txtCantidad.Text == "")
                MessageBox.Show("No puedes dejar los espacios en blanco", "Error", MessageBoxButtons.OK);
            else {
                if (!isValid(txtCantidad.Text) || !isValid(txtPrecio.Text))
                    MessageBox.Show("La cantidad y el precio solo acepta numeros", "Error", MessageBoxButtons.OK);
                else {
                    try
                    {
                        query = "INSERT INTO `papeleriamaxy`.`producto` (`codigo`, `producto`, `cantidad`, `precio`) VALUES ('" + codigo + "', '" + txtNombre.Text + "', '" + txtCantidad.Text + "', '" + txtPrecio.Text + "')";
                        con.consulta(query);
                        MessageBox.Show("El producto " + txtNombre.Text + " ha sido dado de alta", "Producto exitoso", MessageBoxButtons.OK);
                        txtNombre.Clear();
                        txtPrecio.Clear();
                        txtCantidad.Clear();
                        txtCodigo.Clear();
                    }
                    catch {}
                }
            }
        }

        private static bool isValid(String str)
        {
            return Regex.IsMatch(str, @"^[0-9]*\.?[0-9]*$");
        }

        private void txtBaja_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                dgBaja.DataSource = con.busquedaM(txtBaja.Text);
                dgBaja.Columns.Remove("codigo");
                dgBaja.Columns.Remove("precio");
                dgBaja.Columns.Remove("cantidad");
                dgBaja.Columns.Remove("idproducto");
                //dgBaja.Columns.RemoveAt(this.dgBaja.Rows[1].Index);
                dgBaja.Columns[0].Width = 300;
            }
            catch (Exception es)
            {
                Console.WriteLine(es);
            }
        }

        private void dgBaja_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            producto = con.busqueda(dgBaja.CurrentCell.Value.ToString(), false);
            if (producto.Count() > 0)
                idProducto = int.Parse(producto[3]);
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            DialogResult result;
            string query;
            try
            {
                result = MessageBox.Show("Seguro quiere eliminar " + producto[1], "Total", MessageBoxButtons.YesNo);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    query = "DELETE FROM `papeleriamaxy`.`producto` WHERE `idproducto`='" + producto[3] + "'";
                    con.consulta(query);
                    txtBaja.Clear();
                }
            }
            catch (Exception es) { 
            }
            
        }

        private void btnModifiacion_Click(object sender, EventArgs e)
        {
            DialogResult result;
            string nom,query,codigoN;
            int cantidad;
            double precio;
            result = MessageBox.Show("Seguro quiere modificar " + producto[1], "Total", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    codigoN = Microsoft.VisualBasic.Interaction.InputBox("Escriba codigo del producto a actualizar", "Producto", producto[0], 0, 0);
                    nom = Microsoft.VisualBasic.Interaction.InputBox("Escriba nombre del producto a actualizar", "Producto", producto[1], 0, 0); 
                    cantidad = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Escriba la nueva cantidad", "Cantidad", producto[4], 0, 0));
                    precio = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("Escriba el precio del producto", "Producto", producto[2], 0, 0));

                    query = "UPDATE `papeleriamaxy`.`producto` SET `codigo`='" + codigoN + "',`producto`='" + nom + "', `cantidad`='" + cantidad + "', `precio`='" + precio + "' WHERE `idproducto`='" + int.Parse(producto[3]) + "'";
                    con.consulta(query);
                    txtModificacion.Clear();
                }
                catch (Exception es) {
                    MessageBox.Show("Los datos no puedes estar vacios, el precio y la cantidad solo pueden ser numeros");
                    Console.WriteLine(es);
                }
            }
        }

        private void txtModificacion_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                dgModificacion.DataSource = con.busquedaM(txtModificacion.Text);
                dgModificacion.Columns.Remove("codigo");
                dgModificacion.Columns.Remove("precio");
                dgModificacion.Columns.Remove("cantidad");
                dgModificacion.Columns.Remove("idproducto");
                //dgBaja.Columns.RemoveAt(this.dgBaja.Rows[1].Index);
                dgModificacion.Columns[0].Width = 300;
            }
            catch (Exception es)
            {
                Console.WriteLine(es);
            }
        }

        private void dgModificacion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            producto = con.busqueda(dgModificacion.CurrentCell.Value.ToString(), false);
            if (producto.Count() > 0)
                idProducto = int.Parse(producto[3]);
        }

        private void txtConsulta_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                dgConsulta.DataSource = con.busquedaM(txtConsulta.Text);
                //dgBaja.Columns.RemoveAt(this.dgBaja.Rows[1].Index);
            }
            catch (Exception es)
            {
                Console.WriteLine(es);
            }
        }
    }


}
