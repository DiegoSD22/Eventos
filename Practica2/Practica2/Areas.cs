using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica2
{
    public partial class Areas : Form
    {
        public Areas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Area_Rec(string lado, string ancho)
            {
                double ladox, anchox, res;
                string s_res;
                ladox = Convert.ToDouble(lado);
                anchox = Convert.ToDouble(ancho);
                res = ladox * anchox;
                s_res = Convert.ToString(res);
                return s_res;
            }

            string Area_Cir(string radio)
            {
                double radiox, res;
                string s_res;
                radiox = Convert.ToDouble(radio);
                res = (radiox * radiox)*3.1416;
                s_res = Convert.ToString(res);
                return s_res;
            }
            if (checkBox1.Checked)
            {
                textBox3.Enabled = true;
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox4.Text = Area_Cir(textBox3.Text);
            }
            else
            {
                textBox3.Enabled = false;
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox4.Text = Area_Rec(textBox1.Text, textBox2.Text);
                
            }
            
           
        }

        private void Areas_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox3.Enabled = true;
                textBox1.Enabled = false;
                textBox2.Enabled = false;
              
            }
            else
            {
                textBox3.Enabled = false;
                textBox1.Enabled = true;
                textBox2.Enabled = true;
             
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            checkBox1.Checked = false;
        }
    }
}
