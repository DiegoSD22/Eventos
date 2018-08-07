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
    public partial class Buscar : Form
    {
        public Buscar()
        {
            InitializeComponent();
        }

        private void Buscar_Load(object sender, EventArgs e)
        {
            textBox1.Text = "1";
            OleDbConnection ole = new OleDbConnection();
            ole = Base_Datos.conectar();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = ole;
            cmd.CommandText = "SELECT * FROM Tabla_Usuarios WHERE Id=" + textBox1.Text;
            OleDbDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                textBox2.Text = textBox2.Text + reader.GetValue(0).ToString() + "\r\n";
                textBox3.Text = textBox3.Text + reader.GetValue(1).ToString() + "\r\n";
                textBox4.Text = textBox4.Text + reader.GetValue(2).ToString() + "\r\n";
                textBox5.Text = textBox5.Text + reader.GetValue(3).ToString() + "\r\n";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            OleDbConnection ole = new OleDbConnection();
            ole = Base_Datos.conectar();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = ole;
            cmd.CommandText = "SELECT * FROM Tabla_Usuarios WHERE Id=" + textBox1.Text;
            OleDbDataReader reader = cmd.ExecuteReader();
            
            while (reader.Read())
            {
                textBox2.Text = textBox2.Text + reader.GetValue(0).ToString() + "\r\n";
                textBox3.Text = textBox3.Text + reader.GetValue(1).ToString() + "\r\n";
                textBox4.Text = textBox4.Text + reader.GetValue(2).ToString() + "\r\n";
                textBox5.Text = textBox5.Text + reader.GetValue(3).ToString() + "\r\n";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int restador;
            restador = Convert.ToInt16(textBox1.Text);
            if (restador == 1)
            {
                MessageBox.Show("Estas al inicio");
                
            }
            else
            {
                restador = restador - 1;
            }
            textBox1.Text = Convert.ToString(restador);
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            OleDbConnection ole = new OleDbConnection();
            ole = Base_Datos.conectar();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = ole;
            cmd.CommandText = "SELECT * FROM Tabla_Usuarios WHERE Id=" + textBox1.Text;
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                textBox2.Text = textBox2.Text + reader.GetValue(0).ToString() + "\r\n";
                textBox3.Text = textBox3.Text + reader.GetValue(1).ToString() + "\r\n";
                textBox4.Text = textBox4.Text + reader.GetValue(2).ToString() + "\r\n";
                textBox5.Text = textBox5.Text + reader.GetValue(3).ToString() + "\r\n";
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            int sumador;
            sumador = Convert.ToInt16(textBox1.Text);
            if (sumador == 10)
            {
                MessageBox.Show("Estas al final");

            }
            else
            {
                sumador = sumador + 1;
            }
            textBox1.Text = Convert.ToString(sumador);
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            OleDbConnection ole = new OleDbConnection();
            ole = Base_Datos.conectar();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = ole;
            cmd.CommandText = "SELECT * FROM Tabla_Usuarios WHERE Id=" + textBox1.Text;
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                textBox2.Text = textBox2.Text + reader.GetValue(0).ToString() + "\r\n";
                textBox3.Text = textBox3.Text + reader.GetValue(1).ToString() + "\r\n";
                textBox4.Text = textBox4.Text + reader.GetValue(2).ToString() + "\r\n";
                textBox5.Text = textBox5.Text + reader.GetValue(3).ToString() + "\r\n";
            }
        }
    }
}
