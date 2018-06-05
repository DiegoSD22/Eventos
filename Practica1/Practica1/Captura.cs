using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1
{
    public partial class Captura : Form
    {
        public Captura()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nombre, fecha;
            int cuenta, diasl, diasn, bono;
            nombre = textBox1.Text;
            cuenta = Convert.ToInt16(textBox2.Text);
            fecha = textBox3.Text;
            bono = Convert.ToInt16(textBox4.Text);
            diasl = Convert.ToInt16(textBox5.Text);
            diasn = Convert.ToInt16(textBox6.Text);
            float salario = diasl * 700;
            float bono2 = (bono * salario) / 100;
            Recibo fr3 = new Recibo();
            fr3.textBox1.Text = Convert.ToString(salario);
            fr3.textBox2.Text = Convert.ToString(bono2);
            float totalp = salario + bono2;
            fr3.textBox3.Text = Convert.ToString(totalp);
            float faltas = diasn * 700;
            fr3.textBox4.Text = Convert.ToString(faltas);
            float ISR = (salario * 12) / 100;
            fr3.textBox5.Text = Convert.ToString(ISR);
            float SS = (salario * 5) / 100;
            fr3.textBox6.Text = Convert.ToString(SS);
            float totald = faltas + ISR + SS;
            fr3.textBox7.Text = Convert.ToString(totald);
            float neto = totalp - totald;
            fr3.textBox8.Text = Convert.ToString(neto);
            fr3.Show();
        }
    }
}
