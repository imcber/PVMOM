using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto_de_Venta
{
    public partial class Ventas : Form
    {
        connectMySql con = new connectMySql();
        public Ventas()
        {
            InitializeComponent();
            con.conection();
            buscarVentas("init", "init");
        }

        private void regresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buscarVentas(textBox1.Text, textBox2.Text);
        }

        private void buscarVentas(string fecha1, string fecha2)
        {
            try {
                if (fecha1 != "" && fecha2 != ""){
                    dgVentas.DataSource = con.busquedaVentas(fecha1, fecha2);
                    dgVentas.Columns.Remove("codigo");
                }
            }
            catch (Exception es)
            {
                Console.WriteLine("Error:" + es);
            }
        }
    }
}
