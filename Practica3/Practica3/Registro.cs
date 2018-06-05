using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica3
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Entrada fr1 = new Entrada();
            for(int i=0; i<20; i++)
            {
                if(Entrada.Usuario[i,0]==null)
                {

                    Entrada.Usuario[i, 0] = textBox1.Text;
                    Entrada.Usuario[i, 1] = textBox2.Text;
                    if(textBox3.Text==textBox4.Text)
                    {
                        Entrada.Usuario[i, 2] = textBox3.Text;
                    }
                    else
                    {
                        MessageBox.Show("Las contraseñas no coinciden");
                    }
                 
                    if(radioButton1.Checked)
                    {
                        Entrada.Usuario[i, 3] = "U";
                    }
                    else if(radioButton2.Checked)
                    {
                        Entrada.Usuario[i, 3] = "A";
                    }
                    else
                    {
                        MessageBox.Show("No selecciono tipo de usuario");
                    }
                    Entrada.Usuario[i, 4] = textBox6.Text;
                    Entrada.Usuario[i, 5] = textBox7.Text;
                    i = 21;
                    fr1.Show();
                }
            }

        }
    }
}
