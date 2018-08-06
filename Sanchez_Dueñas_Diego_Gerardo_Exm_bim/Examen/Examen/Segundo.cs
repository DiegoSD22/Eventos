using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen
{
    public partial class Segundo : Form
    {
        public Segundo()
        {
            InitializeComponent();
        }

        private void Segundo_Load(object sender, EventArgs e)
        {
            string usu()
            {
                string usuario;
                usuario = Sesion.Usuario[0, 1];

                return usuario;
            }

            textBox2.Text = usu();
            
            Generar.Crear_Aleatorios();
            for(int i=0; i<10; i++)
            {
                textBox1.Text = textBox1.Text + Generar.nums[i] + "\n ";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ubicacion(string num)
            {
                int indice=0;
                for(int i=0; i<10; i++)
                {
                    if (num == Generar.nums[i])
                    {
                        indice = i;
                        
                    }
                    else
                    {
                        
                       
                    }
                }
                return indice;
            }

            ;
            string ub;
            ub = Convert.ToString(ubicacion(textBox3.Text));

            textBox4.Text = ub;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nuevo(string ubicacion, string nue)
            {
                string nuevos;
                int indice = 0;
                indice = Convert.ToInt32(ubicacion);
                Generar.nums[indice] = nue;
                nuevos = Generar.nums[indice];
                return Generar.nums[indice];
            }
            for (int i = 0; i < 10; i++)
            {


                textBox1.Text =textBox1.Text+ nuevo(textBox5.Text, textBox6.Text);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Sesion ses = new Sesion();
            ses.Show();
            Close();
        }
    }
}
