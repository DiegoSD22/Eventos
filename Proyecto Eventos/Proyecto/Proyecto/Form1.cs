using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Inicio : Form
    {
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

        }
    }
}
