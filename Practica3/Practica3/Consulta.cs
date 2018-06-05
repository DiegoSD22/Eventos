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
    public partial class Consulta : Form
    {
        public Consulta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num;
            Entrada entr = new Entrada();
            int M_Consulta (String ID)
            {
                
                int enc = 0, indice = 0;
                for(int i=0; i<20; i++)
                {
                    if (ID == Entrada.Usuario[i, 0]){
                        enc = 1;
                        indice = i;
                    }
                }
                return indice;
            }
            num=M_Consulta(textBox1.Text);
            
            textBox3.Text = Entrada.Usuario[num, 1];
            textBox4.Text = Entrada.Usuario[num, 2];
            textBox5.Text = Entrada.Usuario[num, 3];
            textBox6.Text = Entrada.Usuario[num, 4];
            textBox7.Text = Entrada.Usuario[num, 5];
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin adm = new Admin();
            adm.Show();
        }
    }
}
