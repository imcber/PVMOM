using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Punto_de_Venta
{
    class connectMySql
    {

        MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
        
        public void conection() {
            builder.Server = "192.168.100.33";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "papeleriamaxy";
            builder.Port = 3306;
        }

        public void altaVentas(string codigo, string nombre, string precio, string cantidad)
        {
            string fecha = DateTime.Now.ToString("G");
            MySqlConnection conn = new MySqlConnection(builder.ToString());
            
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO ventas (`codigo`, `producto`, `cantidad`,`precio`,`fecha` ) VALUES ('" + codigo + "','" + nombre + "','" + cantidad + "','" + precio + "',CURDATE())";
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
        }
        public void consulta(string query)
        {
            MySqlConnection conn = new MySqlConnection(builder.ToString());
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = query;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
        }

        public List<string> busqueda(string codigo,bool band) {
            List<string> producto = new List<string>();
            MySqlConnection conn = new MySqlConnection(builder.ToString());
            
                MySqlCommand cmd = conn.CreateCommand();
                MySqlDataReader reader;
                if (band)
                    cmd.CommandText = "SELECT * FROM producto where codigo like '%" + codigo + "%'";
                else
                    cmd.CommandText = "SELECT * FROM producto where idproducto = '" + codigo + "'";

                conn.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    producto = new List<string>();
                    producto.Add(!reader.IsDBNull(1) ? reader.GetString("codigo") : "");//0
                    producto.Add(!reader.IsDBNull(2) ? reader.GetString("producto") : "");//1
                    producto.Add(!reader.IsDBNull(3) ? reader.GetString("precio") : "ERROR");//2
                    producto.Add(!reader.IsDBNull(0) ? reader.GetString("idproducto") : "");//3
                    producto.Add(!reader.IsDBNull(4) ? reader.GetString("cantidad") : "");//4
                if (codigo == producto[0])
                    {
                        break;
                    }
                }
            conn.Close();
            
            return producto; 
        }

        public DataTable busquedaM(string nombre) {
            DataTable dt = new DataTable();
            MySqlConnection conn = new MySqlConnection(builder.ToString());
            
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM producto where producto like '%" + nombre + "%' OR codigo like '%" + nombre + "%'";
                conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                conn.Close();
        
            return dt;
        }

        public DataTable busquedaVentas(string fechaMenor, string fechaMayor)
        {
            DataTable dt = new DataTable();
            MySqlConnection conn = new MySqlConnection(builder.ToString());
            String sqlCom = "select * from ventas where fecha >= '" + fechaMenor + "' and fecha <= '" + fechaMayor + "'";    
            MySqlCommand cmd = conn.CreateCommand();
            if (fechaMayor == "init")
            {
                sqlCom = "select * from ventas where fecha >= CURDATE() and fecha <= CURDATE()";
            }
            cmd.CommandText = sqlCom;
            conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            conn.Close();

            return dt;
        }

        public void updateCantidad(string id, string cantidad, string cantidadCompra)
        {
            string fecha = DateTime.Now.ToString("G");
            MySqlConnection conn = new MySqlConnection(builder.ToString());

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE producto set cantidad = '" + (Double.Parse(cantidad) - Double.Parse(cantidadCompra)) + "' where idproducto = '" + id + "'";
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public List<List<string>> busquedaVentasDelDia(string fechaMenor, string fechaMayor)
        {
            List<List<string>> productos = new List<List<string>>();
            List<string> producto = new List<string>();
            MySqlDataReader reader;
            DataTable dt = new DataTable();
            MySqlConnection conn = new MySqlConnection(builder.ToString());
            String sqlCom = "select * from ventas where fecha >= '" + fechaMenor + "' and fecha <= '" + fechaMayor + "'";
            MySqlCommand cmd = conn.CreateCommand();
            if (fechaMayor == "init")
            {
                sqlCom = "select * from ventas where fecha >= CURDATE() and fecha <= CURDATE()";
            }
            cmd.CommandText = sqlCom;
            conn.Open(); reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                producto = new List<string>();
                producto.Add(reader.GetString("precio"));//0
                producto.Add(reader.GetString("cantidad"));//1

                productos.Add(producto);
            }
            conn.Close();

            return productos;
        }

    }
}
