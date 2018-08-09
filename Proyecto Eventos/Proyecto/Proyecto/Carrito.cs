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

namespace Proyecto
{
    public partial class Carrito : Form
    {
        int id=0;
        public Carrito()
        {
            InitializeComponent();
        }

        private void Carrito_Load(object sender, EventArgs e)
        {
             for (int i = 0; i < 90; i++)
             {
                 
                 
                     
                     textBox2.Text = textBox2.Text + Compras.carrito[i, 1] + "\r\n";
                     textBox3.Text = textBox3.Text + Compras.carrito[i, 2] + "\r\n";
                     textBox4.Text = textBox4.Text + Compras.carrito[i, 3] + "\r\n";
                 
             }
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection nuevo = new OleDbConnection();
            nuevo = Metodos.Conectar();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = nuevo;
            DialogResult dialogResult = MessageBox.Show("¿Estas seguro que deseas hacer esta compra?", "Alerta", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                for (int i = 0; i < 90; i++)
                {
                    if (Compras.carrito[i, 0] == null)
                    {
                        i = 90;
                    }
                    else
                    {
                        cmd.CommandText = "Insert into comprass VALUES(" + id + "," + "'" + Compras.carrito[i, 0] + "'" + "," + "'" + Compras.carrito[i, 1] + "'" + "," + "'" + Compras.carrito[i, 2] + "'" + "," + "'" + Compras.carrito[i, 3] + "'" + ")";
                        OleDbDataReader reader = cmd.ExecuteReader();
                        reader.Close();                       
                        id = id + 1;
                    }
                }
                MessageBox.Show("Se realizo la compra con exito");
                Close();
            }
        }
    }
}
