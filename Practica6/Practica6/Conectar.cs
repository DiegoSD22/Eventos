using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Practica6
{
    public partial class Conectar : Form
    {
        OleDbConnection con;
        string cad_con = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:/Programacion orientada a eventos/Practica6/prueba.accdb";
        public Conectar()
        {
            InitializeComponent();
        }

        private void Conectar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Base_Datos.conectar();
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Base_Datos.Desconectar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Datos da = new Datos();
            da.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Buscar bus = new Buscar();
            bus.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Borrar del = new Borrar();
            del.Show();
        }
    }
}
