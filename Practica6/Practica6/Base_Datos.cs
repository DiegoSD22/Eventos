using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Practica6
{
    class Base_Datos
    {
        public static OleDbConnection con;
        public static string cad_con = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:/Programacion orientada a eventos/Practica6/prueba.accdb";
        public static OleDbConnection conectar()
        {
        


            try
            {
                con = new OleDbConnection(@cad_con);
                con.Open();
                
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return con;
        }

        public static void Desconectar()
        {
            
            con.Close();
            MessageBox.Show("Se cerro la conexion");

        }

        public static void consulta()
        {
            Datos dat = new Datos();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Tabla_Usuarios";
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                dat.textBox1.Text = dat.textBox1.Text + reader.GetValue(0).ToString() + "\n";
                dat.textBox2.Text = dat.textBox2.Text + reader.GetValue(1).ToString() + "\n";
                dat.textBox3.Text = dat.textBox3.Text + reader.GetValue(2).ToString() + "\n";
                dat.textBox4.Text = dat.textBox4.Text + reader.GetValue(3).ToString() + "\n";
            }
        }

    }
}
