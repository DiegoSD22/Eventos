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
    public partial class Musica : Form
    {
        public Musica()
        {
            InitializeComponent();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                for (int i = 0; i < 90; i++)
                {


                    if (Compras.carrito[i, 0] == null)
                    {
                        //0=usuario
                        //1=articulo
                        //2=depto
                        //3=monto

                        Compras.carrito[i, 0] = Inicio.usuario;
                        Compras.carrito[i, 1] = "bateria pearl";
                        Compras.carrito[i, 2] = "musica";
                        Compras.carrito[i, 3] = "14000";
                        i = 90;
                    }



                }
            }
            else if (checkBox1.Checked == false)
            {
                for (int i = 0; i < 90; i++)
                {
                    if (Compras.carrito[i, 1] == "bateria pearl")
                    {
                        Compras.carrito[i, 0] = null;
                        Compras.carrito[i, 1] = null;
                        Compras.carrito[i, 2] = null;
                        Compras.carrito[i, 3] = null;
                        i = 90;
                    }
                }
            }


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Carrito carrito = new Carrito();
            carrito.Show();
            Close();
        }

        private void checkBox5_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                for (int i = 0; i < 90; i++)
                {


                    if (Compras.carrito[i, 0] == null)
                    {
                        //0=usuario
                        //1=articulo
                        //2=depto
                        //3=monto

                        Compras.carrito[i, 0] = Inicio.usuario;
                        Compras.carrito[i, 1] = "amplificador orange";
                        Compras.carrito[i, 2] = "musica";
                        Compras.carrito[i, 3] = "4000";
                        i = 90;
                    }



                }
            }
            else if (checkBox5.Checked == false)
            {
                for (int i = 0; i < 90; i++)
                {
                    if (Compras.carrito[i, 1] == "amplificador orange")
                    {
                        Compras.carrito[i, 0] = null;
                        Compras.carrito[i, 1] = null;
                        Compras.carrito[i, 2] = null;
                        Compras.carrito[i, 3] = null;
                        i = 90;
                    }
                }
            }
        }

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                for (int i = 0; i < 90; i++)
                {


                    if (Compras.carrito[i, 0] == null)
                    {
                        //0=usuario
                        //1=articulo
                        //2=depto
                        //3=monto

                        Compras.carrito[i, 0] = Inicio.usuario;
                        Compras.carrito[i, 1] = "disco kakk";
                        Compras.carrito[i, 2] = "musica";
                        Compras.carrito[i, 3] = "600";
                        i = 90;
                    }



                }
            }
            else if (checkBox2.Checked == false)
            {
                for (int i = 0; i < 90; i++)
                {
                    if (Compras.carrito[i, 1] == "disco kakk")
                    {
                        Compras.carrito[i, 0] = null;
                        Compras.carrito[i, 1] = null;
                        Compras.carrito[i, 2] = null;
                        Compras.carrito[i, 3] = null;
                        i = 90;
                    }
                }
            }
        }

        private void checkBox3_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                for (int i = 0; i < 90; i++)
                {


                    if (Compras.carrito[i, 0] == null)
                    {
                        //0=usuario
                        //1=articulo
                        //2=depto
                        //3=monto

                        Compras.carrito[i, 0] = Inicio.usuario;
                        Compras.carrito[i, 1] = "guitarra yamaha";
                        Compras.carrito[i, 2] = "musica";
                        Compras.carrito[i, 3] = "8000";
                        i = 90;
                    }



                }
            }
            else if (checkBox3.Checked == false)
            {
                for (int i = 0; i < 90; i++)
                {
                    if (Compras.carrito[i, 1] == "guitarra yamaha")
                    {
                        Compras.carrito[i, 0] = null;
                        Compras.carrito[i, 1] = null;
                        Compras.carrito[i, 2] = null;
                        Compras.carrito[i, 3] = null;
                        i = 90;
                    }
                }
            }
        }

        private void checkBox4_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                for (int i = 0; i < 90; i++)
                {


                    if (Compras.carrito[i, 0] == null)
                    {
                        //0=usuario
                        //1=articulo
                        //2=depto
                        //3=monto

                        Compras.carrito[i, 0] = Inicio.usuario;
                        Compras.carrito[i, 1] = "bateria yamaha";
                        Compras.carrito[i, 2] = "musica";
                        Compras.carrito[i, 3] = "20000";
                        i = 90;
                    }



                }
            }
            else if (checkBox4.Checked == false)
            {
                for (int i = 0; i < 90; i++)
                {
                    if (Compras.carrito[i, 1] == "bateria yamaha")
                    {
                        Compras.carrito[i, 0] = null;
                        Compras.carrito[i, 1] = null;
                        Compras.carrito[i, 2] = null;
                        Compras.carrito[i, 3] = null;
                        i = 90;
                    }
                }
            }
        }

        private void checkBox6_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                for (int i = 0; i < 90; i++)
                {


                    if (Compras.carrito[i, 0] == null)
                    {
                        //0=usuario
                        //1=articulo
                        //2=depto
                        //3=monto

                        Compras.carrito[i, 0] = Inicio.usuario;
                        Compras.carrito[i, 1] = "guitarra les paul";
                        Compras.carrito[i, 2] = "musica";
                        Compras.carrito[i, 3] = "12000";
                        i = 90;
                    }



                }
            }
            else if (checkBox6.Checked == false)
            {
                for (int i = 0; i < 90; i++)
                {
                    if (Compras.carrito[i, 1] == "guitarra les paul")
                    {
                        Compras.carrito[i, 0] = null;
                        Compras.carrito[i, 1] = null;
                        Compras.carrito[i, 2] = null;
                        Compras.carrito[i, 3] = null;
                        i = 90;
                    }
                }
            }
        }

        private void checkBox7_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true)
            {
                for (int i = 0; i < 90; i++)
                {


                    if (Compras.carrito[i, 0] == null)
                    {
                        //0=usuario
                        //1=articulo
                        //2=depto
                        //3=monto

                        Compras.carrito[i, 0] = Inicio.usuario;
                        Compras.carrito[i, 1] = "the beatles hits";
                        Compras.carrito[i, 2] = "musica";
                        Compras.carrito[i, 3] = "1000";
                        i = 90;
                    }



                }
            }
            else if (checkBox7.Checked == false)
            {
                for (int i = 0; i < 90; i++)
                {
                    if (Compras.carrito[i, 1] == "the beatles hits")
                    {
                        Compras.carrito[i, 0] = null;
                        Compras.carrito[i, 1] = null;
                        Compras.carrito[i, 2] = null;
                        Compras.carrito[i, 3] = null;
                        i = 90;
                    }
                }
            }
        }

        private void checkBox10_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox10.Checked == true)
            {
                for (int i = 0; i < 90; i++)
                {


                    if (Compras.carrito[i, 0] == null)
                    {
                        //0=usuario
                        //1=articulo
                        //2=depto
                        //3=monto

                        Compras.carrito[i, 0] = Inicio.usuario;
                        Compras.carrito[i, 1] = "queen hits";
                        Compras.carrito[i, 2] = "musica";
                        Compras.carrito[i, 3] = "600";
                        i = 90;
                    }



                }
            }
            else if (checkBox10.Checked == false)
            {
                for (int i = 0; i < 90; i++)
                {
                    if (Compras.carrito[i, 1] == "queen hits")
                    {
                        Compras.carrito[i, 0] = null;
                        Compras.carrito[i, 1] = null;
                        Compras.carrito[i, 2] = null;
                        Compras.carrito[i, 3] = null;
                        i = 90;
                    }
                }
            }
        }

        private void checkBox8_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox8.Checked == true)
            {
                for (int i = 0; i < 90; i++)
                {


                    if (Compras.carrito[i, 0] == null)
                    {
                        //0=usuario
                        //1=articulo
                        //2=depto
                        //3=monto

                        Compras.carrito[i, 0] = Inicio.usuario;
                        Compras.carrito[i, 1] = "elvis presley hits";
                        Compras.carrito[i, 2] = "musica";
                        Compras.carrito[i, 3] = "800";
                        i = 90;
                    }



                }
            }
            else if (checkBox8.Checked == false)
            {
                for (int i = 0; i < 90; i++)
                {
                    if (Compras.carrito[i, 1] == "elvis presley hits")
                    {
                        Compras.carrito[i, 0] = null;
                        Compras.carrito[i, 1] = null;
                        Compras.carrito[i, 2] = null;
                        Compras.carrito[i, 3] = null;
                        i = 90;
                    }
                }
            }
        }

        private void checkBox9_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox9.Checked == true)
            {
                for (int i = 0; i < 90; i++)
                {


                    if (Compras.carrito[i, 0] == null)
                    {
                        //0=usuario
                        //1=articulo
                        //2=depto
                        //3=monto

                        Compras.carrito[i, 0] = Inicio.usuario;
                        Compras.carrito[i, 1] = "the doors hits";
                        Compras.carrito[i, 2] = "musica";
                        Compras.carrito[i, 3] = "500";
                        i = 90;
                    }



                }
            }
            else if (checkBox9.Checked == false)
            {
                for (int i = 0; i < 90; i++)
                {
                    if (Compras.carrito[i, 1] == "the doors hits")
                    {
                        Compras.carrito[i, 0] = null;
                        Compras.carrito[i, 1] = null;
                        Compras.carrito[i, 2] = null;
                        Compras.carrito[i, 3] = null;
                        i = 90;
                    }
                }
            }
        }

        private void checkBox11_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox11.Checked == true)
            {
                for (int i = 0; i < 90; i++)
                {


                    if (Compras.carrito[i, 0] == null)
                    {
                        //0=usuario
                        //1=articulo
                        //2=depto
                        //3=monto

                        Compras.carrito[i, 0] = Inicio.usuario;
                        Compras.carrito[i, 1] = "ed sheeran x";
                        Compras.carrito[i, 2] = "musica";
                        Compras.carrito[i, 3] = "200";
                        i = 90;
                    }



                }
            }
            else if (checkBox11.Checked == false)
            {
                for (int i = 0; i < 90; i++)
                {
                    if (Compras.carrito[i, 1] == "ed sheeran x")
                    {
                        Compras.carrito[i, 0] = null;
                        Compras.carrito[i, 1] = null;
                        Compras.carrito[i, 2] = null;
                        Compras.carrito[i, 3] = null;
                        i = 90;
                    }
                }
            }
        }

        private void checkBox12_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox12.Checked == true)
            {
                for (int i = 0; i < 90; i++)
                {


                    if (Compras.carrito[i, 0] == null)
                    {
                        //0=usuario
                        //1=articulo
                        //2=depto
                        //3=monto

                        Compras.carrito[i, 0] = Inicio.usuario;
                        Compras.carrito[i, 1] = "guitarra ibanez";
                        Compras.carrito[i, 2] = "musica";
                        Compras.carrito[i, 3] = "8000";
                        i = 90;
                    }



                }
            }
            else if (checkBox12.Checked == false)
            {
                for (int i = 0; i < 90; i++)
                {
                    if (Compras.carrito[i, 1] == "guitarra ibanez")
                    {
                        Compras.carrito[i, 0] = null;
                        Compras.carrito[i, 1] = null;
                        Compras.carrito[i, 2] = null;
                        Compras.carrito[i, 3] = null;
                        i = 90;
                    }
                }
            }
        }

        private void checkBox13_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox13.Checked == true)
            {
                for (int i = 0; i < 90; i++)
                {


                    if (Compras.carrito[i, 0] == null)
                    {
                        //0=usuario
                        //1=articulo
                        //2=depto
                        //3=monto

                        Compras.carrito[i, 0] = Inicio.usuario;
                        Compras.carrito[i, 1] = "amplificador line 6";
                        Compras.carrito[i, 2] = "musica";
                        Compras.carrito[i, 3] = "15000";
                        i = 90;
                    }



                }
            }
            else if (checkBox13.Checked == false)
            {
                for (int i = 0; i < 90; i++)
                {
                    if (Compras.carrito[i, 1] == "amplificador line 6")
                    {
                        Compras.carrito[i, 0] = null;
                        Compras.carrito[i, 1] = null;
                        Compras.carrito[i, 2] = null;
                        Compras.carrito[i, 3] = null;
                        i = 90;
                    }
                }
            }
        }

        private void checkBox14_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox14.Checked == true)
            {
                for (int i = 0; i < 90; i++)
                {


                    if (Compras.carrito[i, 0] == null)
                    {
                        //0=usuario
                        //1=articulo
                        //2=depto
                        //3=monto

                        Compras.carrito[i, 0] = Inicio.usuario;
                        Compras.carrito[i, 1] = "amplificador marshall";
                        Compras.carrito[i, 2] = "musica";
                        Compras.carrito[i, 3] = "15000";
                        i = 90;
                    }



                }
            }
            else if (checkBox14.Checked == false)
            {
                for (int i = 0; i < 90; i++)
                {
                    if (Compras.carrito[i, 1] == "amplificador marshall")
                    {
                        Compras.carrito[i, 0] = null;
                        Compras.carrito[i, 1] = null;
                        Compras.carrito[i, 2] = null;
                        Compras.carrito[i, 3] = null;
                        i = 90;
                    }
                }
            }
        }

        private void checkBox15_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox15.Checked == true)
            {
                for (int i = 0; i < 90; i++)
                {


                    if (Compras.carrito[i, 0] == null)
                    {
                        //0=usuario
                        //1=articulo
                        //2=depto
                        //3=monto

                        Compras.carrito[i, 0] = Inicio.usuario;
                        Compras.carrito[i, 1] = "arctic monkeys am";
                        Compras.carrito[i, 2] = "musica";
                        Compras.carrito[i, 3] = "200";
                        i = 90;
                    }



                }
            }
            else if (checkBox15.Checked == false)
            {
                for (int i = 0; i < 90; i++)
                {
                    if (Compras.carrito[i, 1] == "arctic monkeys am")
                    {
                        Compras.carrito[i, 0] = null;
                        Compras.carrito[i, 1] = null;
                        Compras.carrito[i, 2] = null;
                        Compras.carrito[i, 3] = null;
                        i = 90;
                    }
                }
            }
        }
    }
}
