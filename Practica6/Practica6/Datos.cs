using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Practica6
{
    public partial class Datos : Form
    {
        OleDbConnection con;
        string cad_con = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:/Programacion orientada a eventos/Practica6/prueba.accdb";
        public Datos()
        {
            InitializeComponent();
        }

        private void Datos_Load(object sender, EventArgs e)
        {
            
            OleDbConnection ole = new OleDbConnection();
            ole = Base_Datos.conectar();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = ole;
            cmd.CommandText = "SELECT * FROM Tabla_Usuarios";
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                textBox1.Text = textBox1.Text + reader.GetValue(0).ToString() + "\r\n";
                textBox2.Text = textBox2.Text + reader.GetValue(1).ToString() + "\r\n";
                textBox3.Text = textBox3.Text + reader.GetValue(2).ToString() + "\r\n";
                textBox4.Text = textBox4.Text + reader.GetValue(3).ToString() + "\r\n";
            }
           
        }
    }
}
