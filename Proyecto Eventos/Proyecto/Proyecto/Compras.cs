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
    public partial class Compras : Form
    {
        public static string[,] carrito = new string[90, 4];
        public Compras()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Electronica electronica = new Electronica();
            electronica.Show();
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Musica musica = new Musica();
            musica.Show();
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            LineaBlanca lineaBlanca = new LineaBlanca();
            lineaBlanca.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Audio audio = new Audio();
            audio.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Caballeros caballeros = new Caballeros();
            caballeros.Show();
        }
    }
}
