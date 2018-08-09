﻿using System;
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
    public partial class Caballeros : Form
    {
        public Caballeros()
        {
            InitializeComponent();
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
                        Compras.carrito[i, 1] = "traje gris";
                        Compras.carrito[i, 2] = "caballeros";
                        Compras.carrito[i, 3] = "2000";
                        i = 90;
                    }



                }
            }
            else if (checkBox1.Checked == false)
            {
                for (int i = 0; i < 90; i++)
                {
                    if (Compras.carrito[i, 1] == "traje gris")
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

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
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
                        Compras.carrito[i, 1] = "camisa cuadros";
                        Compras.carrito[i, 2] = "caballeros";
                        Compras.carrito[i, 3] = "400";
                        i = 90;
                    }



                }
            }
            else if (checkBox2.Checked == false)
            {
                for (int i = 0; i < 90; i++)
                {
                    if (Compras.carrito[i, 1] == "camisa cuadros")
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
                        Compras.carrito[i, 1] = "chamarra azul";
                        Compras.carrito[i, 2] = "caballeros";
                        Compras.carrito[i, 3] = "600";
                        i = 90;
                    }



                }
            }
            else if (checkBox3.Checked == false)
            {
                for (int i = 0; i < 90; i++)
                {
                    if (Compras.carrito[i, 1] == "chamarra azul")
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
                        Compras.carrito[i, 1] = "saco raro";
                        Compras.carrito[i, 2] = "caballeros";
                        Compras.carrito[i, 3] = "5000";
                        i = 90;
                    }



                }
            }
            else if (checkBox4.Checked == false)
            {
                for (int i = 0; i < 90; i++)
                {
                    if (Compras.carrito[i, 1] == "saco raro")
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
                        Compras.carrito[i, 1] = "saco negro";
                        Compras.carrito[i, 2] = "caballeros";
                        Compras.carrito[i, 3] = "1000";
                        i = 90;
                    }



                }
            }
            else if (checkBox5.Checked == false)
            {
                for (int i = 0; i < 90; i++)
                {
                    if (Compras.carrito[i, 1] == "saco negro")
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
                        Compras.carrito[i, 1] = "camisa boss";
                        Compras.carrito[i, 2] = "caballeros";
                        Compras.carrito[i, 3] = "500";
                        i = 90;
                    }



                }
            }
            else if (checkBox6.Checked == false)
            {
                for (int i = 0; i < 90; i++)
                {
                    if (Compras.carrito[i, 1] == "camisa boss")
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
                        Compras.carrito[i, 1] = "camisa mi rey";
                        Compras.carrito[i, 2] = "caballeros";
                        Compras.carrito[i, 3] = "800";
                        i = 90;
                    }



                }
            }
            else if (checkBox7.Checked == false)
            {
                for (int i = 0; i < 90; i++)
                {
                    if (Compras.carrito[i, 1] == "camisa mi rey")
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
                        Compras.carrito[i, 1] = "camisa algodon";
                        Compras.carrito[i, 2] = "caballeros";
                        Compras.carrito[i, 3] = "550";
                        i = 90;
                    }



                }
            }
            else if (checkBox8.Checked == false)
            {
                for (int i = 0; i < 90; i++)
                {
                    if (Compras.carrito[i, 1] == "camisa algodon")
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
                        Compras.carrito[i, 1] = "chamarra frio";
                        Compras.carrito[i, 2] = "caballeros";
                        Compras.carrito[i, 3] = "1000";
                        i = 90;
                    }



                }
            }
            else if (checkBox9.Checked == false)
            {
                for (int i = 0; i < 90; i++)
                {
                    if (Compras.carrito[i, 1] == "chamarra frio")
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
                        Compras.carrito[i, 1] = "pantalon diesel";
                        Compras.carrito[i, 2] = "caballeros";
                        Compras.carrito[i, 3] = "600";
                        i = 90;
                    }



                }
            }
            else if (checkBox10.Checked == false)
            {
                for (int i = 0; i < 90; i++)
                {
                    if (Compras.carrito[i, 1] == "pantalon diesel")
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
                        Compras.carrito[i, 1] = "chamarra cierre";
                        Compras.carrito[i, 2] = "caballeros";
                        Compras.carrito[i, 3] = "950";
                        i = 90;
                    }



                }
            }
            else if (checkBox11.Checked == false)
            {
                for (int i = 0; i < 90; i++)
                {
                    if (Compras.carrito[i, 1] == "chamarra cierre")
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
                        Compras.carrito[i, 1] = "camisa pansky";
                        Compras.carrito[i, 2] = "caballeros";
                        Compras.carrito[i, 3] = "1500";
                        i = 90;
                    }



                }
            }
            else if (checkBox12.Checked == false)
            {
                for (int i = 0; i < 90; i++)
                {
                    if (Compras.carrito[i, 1] == "camisa pansky")
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
                        Compras.carrito[i, 1] = "playera polo";
                        Compras.carrito[i, 2] = "caballeros";
                        Compras.carrito[i, 3] = "1000";
                        i = 90;
                    }



                }
            }
            else if (checkBox13.Checked == false)
            {
                for (int i = 0; i < 90; i++)
                {
                    if (Compras.carrito[i, 1] == "playera polo")
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
                        Compras.carrito[i, 1] = "playera cuadros";
                        Compras.carrito[i, 2] = "caballeros";
                        Compras.carrito[i, 3] = "300";
                        i = 90;
                    }



                }
            }
            else if (checkBox14.Checked == false)
            {
                for (int i = 0; i < 90; i++)
                {
                    if (Compras.carrito[i, 1] == "playera cuadros")
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
                        Compras.carrito[i, 1] = "saco otp";
                        Compras.carrito[i, 2] = "caballeros";
                        Compras.carrito[i, 3] = "850";
                        i = 90;
                    }



                }
            }
            else if (checkBox15.Checked == false)
            {
                for (int i = 0; i < 90; i++)
                {
                    if (Compras.carrito[i, 1] == "saco otp")
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
