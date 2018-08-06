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
    public partial class Inicio : Form
    {
        string estado = "A";
        public Inicio()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            string text = textBox2.Text;
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
                textBox2.Text = text;

            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
                textBox2.Text = text;
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            string text = textBox2.Text;
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
                textBox2.Text = text;

            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
                textBox2.Text = text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Metodos.Iniciar(textBox1.Text, textBox2.Text);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
