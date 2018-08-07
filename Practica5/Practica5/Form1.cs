using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Generar.Crear_Aleatorios();
            for (int i = 0; i < 100; i++)
            {
                textBox1.Text = textBox1.Text + Generar.nums[i]+"\n ";
            }
            }
    }
}
