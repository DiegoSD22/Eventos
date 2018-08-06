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
    public partial class Administrador : Form
    {
        public Administrador()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Agregar agregar = new Agregar();
            agregar.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Borrar borrar = new Borrar();
            borrar.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Editar EDITAR = new Editar();
            EDITAR.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {            
            Close();
        }
    }
}
