using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica6
{
    public partial class Borrar : Form
    {
        public Borrar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection ole = new OleDbConnection();
            ole = Base_Datos.conectar();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = ole;
            
            DialogResult dialogResult = MessageBox.Show("Estas seguro?", "Advertencia", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                cmd.CommandText = "DELETE * FROM Tabla_Usuarios WHERE Id=" + textBox1.Text;
                OleDbDataReader reader = cmd.ExecuteReader();
                MessageBox.Show("Se borro con exito");
            }
            else if (dialogResult == DialogResult.No)
            {
                
            }
        }
    }
}
