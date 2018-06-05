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
    public partial class Entrada : Form
    {
        public static string[,] Usuario = new string[20, 6];
        public Entrada()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool Localizar_Usuario(string Usuarios, string pass)
            {
                bool resp=false;
                for(int i=0; i<5; i++)
                {
                   if(Usuario[i,1]==Usuarios && Usuario[i,2]==pass)
                    {
                        resp = true;
                        for(int j=0; j<5; j++)
                        {
                            if(Usuario[i,3]=="A")
                            {
                                Admin fr2 = new Admin();
                                fr2.Show();
                                j = 6;
                            }
                            else
                            {
                                Alumno fr3 = new Alumno();
                                fr3.Show();
                                j = 6;
                            }
                        }
                        
                    }
                    else
                    {
                        
                        
                    }
                }
              
                return resp;
            }
            
            if(Localizar_Usuario(textBox1.Text, textBox2.Text)==true)
            {
                MessageBox.Show("Usuario correcto");

            }
            else
            {
                MessageBox.Show("Usuario incorrecto");
                Noregis fr5 = new Noregis();
                fr5.Show();
                
            }

        }

        private void Entrada_Load(object sender, EventArgs e)
        {
            Usuario[0, 0] = "0001";
            Usuario[0, 1] = "Diego";
            Usuario[0, 2] = "1234";
            Usuario[0, 3] = "A";
            Usuario[0, 4] = "diegosd2297@gmail.com";
            Usuario[0, 5] = "Sistemas";
            Usuario[1, 0] = "0002";
            Usuario[1, 1] = "Asencio";
            Usuario[1, 2] = "4321";
            Usuario[1, 3] = "U";
            Usuario[1, 4] = "asencio1234@gmail.com";
            Usuario[1, 5] = "Contaduria";

        }
    }
}
