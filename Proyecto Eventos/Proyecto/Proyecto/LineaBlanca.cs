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
    public partial class LineaBlanca : Form
    {
        public LineaBlanca()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
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
                        Compras.carrito[i, 1] = "tostadora pro";
                        Compras.carrito[i, 2] = "linea blanca";
                        Compras.carrito[i, 3] = "5000";
                        i = 90;
                    }



                }
            }
            else if (checkBox1.Checked == false)
            {
                for (int i = 0; i < 90; i++)
                {
                    if (Compras.carrito[i, 1] == "tostadora pro")
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

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
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
                        Compras.carrito[i, 1] = "cafetera x";
                        Compras.carrito[i, 2] = "linea blanca";
                        Compras.carrito[i, 3] = "7000";
                        i = 90;
                    }



                }
            }
            else if (checkBox2.Checked == false)
            {
                for (int i = 0; i < 90; i++)
                {
                    if (Compras.carrito[i, 1] == "cafetera x")
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

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
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
                        Compras.carrito[i, 1] = "estufa 5000g";
                        Compras.carrito[i, 2] = "linea blanca";
                        Compras.carrito[i, 3] = "14000";
                        i = 90;
                    }



                }
            }
            else if (checkBox3.Checked == false)
            {
                for (int i = 0; i < 90; i++)
                {
                    if (Compras.carrito[i, 1] == "estufa 5000g")
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

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
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
                        Compras.carrito[i, 1] = "lavadora bg";
                        Compras.carrito[i, 2] = "linea blanca";
                        Compras.carrito[i, 3] = "10000";
                        i = 90;
                    }



                }
            }
            else if (checkBox4.Checked == false)
            {
                for (int i = 0; i < 90; i++)
                {
                    if (Compras.carrito[i, 1] == "lavadora bg")
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

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
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
                        Compras.carrito[i, 1] = "refrigerador optic";
                        Compras.carrito[i, 2] = "linea blanca";
                        Compras.carrito[i, 3] = "23000";
                        i = 90;
                    }



                }
            }
            else if (checkBox5.Checked == false)
            {
                for (int i = 0; i < 90; i++)
                {
                    if (Compras.carrito[i, 1] == "refrigerador optic")
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

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
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
                        Compras.carrito[i, 1] = "licuadora indutrial";
                        Compras.carrito[i, 2] = "linea blanca";
                        Compras.carrito[i, 3] = "21000";
                        i = 90;
                    }



                }
            }
            else if (checkBox6.Checked == false)
            {
                for (int i = 0; i < 90; i++)
                {
                    if (Compras.carrito[i, 1] == "licuadora industrial")
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

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
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
                        Compras.carrito[i, 1] = "microondas tsm";
                        Compras.carrito[i, 2] = "linea blanca";
                        Compras.carrito[i, 3] = "7000";
                        i = 90;
                    }



                }
            }
            else if (checkBox7.Checked == false)
            {
                for (int i = 0; i < 90; i++)
                {
                    if (Compras.carrito[i, 1] == "microondas tsm")
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

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
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
                        Compras.carrito[i, 1] = "estufa pro gg";
                        Compras.carrito[i, 2] = "linea blanca";
                        Compras.carrito[i, 3] = "19000";
                        i = 90;
                    }



                }
            }
            else if (checkBox8.Checked == false)
            {
                for (int i = 0; i < 90; i++)
                {
                    if (Compras.carrito[i, 1] == "estufa pro gg")
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

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
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
                        Compras.carrito[i, 1] = "microondas liquid";
                        Compras.carrito[i, 2] = "linea blanca";
                        Compras.carrito[i, 3] = "5000";
                        i = 90;
                    }



                }
            }
            else if (checkBox9.Checked == false)
            {
                for (int i = 0; i < 90; i++)
                {
                    if (Compras.carrito[i, 1] == "microondas liquid")
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

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
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
                        Compras.carrito[i, 1] = "estufa lg";
                        Compras.carrito[i, 2] = "linea blanca";
                        Compras.carrito[i, 3] = "9000";
                        i = 90;
                    }



                }
            }
            else if (checkBox10.Checked == false)
            {
                for (int i = 0; i < 90; i++)
                {
                    if (Compras.carrito[i, 1] == "estufa lg")
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

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
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
                        Compras.carrito[i, 1] = "licuadora golden";
                        Compras.carrito[i, 2] = "linea blanca";
                        Compras.carrito[i, 3] = "1000";
                        i = 90;
                    }



                }
            }
            else if (checkBox11.Checked == false)
            {
                for (int i = 0; i < 90; i++)
                {
                    if (Compras.carrito[i, 1] == "licuadora golden")
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

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
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
                        Compras.carrito[i, 1] = "refrigerador ss";
                        Compras.carrito[i, 2] = "linea blanca";
                        Compras.carrito[i, 3] = "12200";
                        i = 90;
                    }



                }
            }
            else if (checkBox12.Checked == false)
            {
                for (int i = 0; i < 90; i++)
                {
                    if (Compras.carrito[i, 1] == "refrigerador ss")
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

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
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
                        Compras.carrito[i, 1] = "lavadora xx";
                        Compras.carrito[i, 2] = "linea blanca";
                        Compras.carrito[i, 3] = "8000";
                        i = 90;
                    }



                }
            }
            else if (checkBox13.Checked == false)
            {
                for (int i = 0; i < 90; i++)
                {
                    if (Compras.carrito[i, 1] == "lavadora xx")
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

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
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
                        Compras.carrito[i, 1] = "aire acondicionado lg";
                        Compras.carrito[i, 2] = "linea blanca";
                        Compras.carrito[i, 3] = "15000";
                        i = 90;
                    }



                }
            }
            else if (checkBox14.Checked == false)
            {
                for (int i = 0; i < 90; i++)
                {
                    if (Compras.carrito[i, 1] == "aire acondicionado lg")
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

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
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
                        Compras.carrito[i, 1] = "tostadora multi";
                        Compras.carrito[i, 2] = "linea blanca";
                        Compras.carrito[i, 3] = "6000";
                        i = 90;
                    }



                }
            }
            else if (checkBox15.Checked == false)
            {
                for (int i = 0; i < 90; i++)
                {
                    if (Compras.carrito[i, 1] == "tostadora multi")
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

        private void button2_Click(object sender, EventArgs e)
        {
            Carrito carrito = new Carrito();
            carrito.Show();
            Close();
        }
    }
}
