using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Drawing;


namespace Practica4
{
    class Operaciones
    {
       public static String Producto(String A, String B)
        {
            int A_m1, A_m2, res;
            String res_cad;
            A_m1 = Convert.ToInt32(A);
            A_m2 = Convert.ToInt32(B);
            res = A_m1 * A_m2;
            res_cad = Convert.ToString(res);
            return res_cad;
        }

        public static String Division(String A, String B)
        {
            int A_m1, A_m2, res=0;
            String res_cad;
            A_m1 = Convert.ToInt32(A);
            A_m2 = Convert.ToInt32(B);
            if (A_m2 == 0)
            {
                MessageBox.Show("No se puede dividir entre 0");
            }
            else
            {
                res = A_m1 / A_m2;
                
            }
            res_cad = Convert.ToString(res);
            return res_cad;
        }

        public static String Potencia(String A, String B)
        {
            int A_m1, A_m2, res=1;
            String res_cad;
            A_m1 = Convert.ToInt32(A);
            A_m2 = Convert.ToInt32(B);
            for(int i=0; i<A_m2; i++)
            {
                res = res * A_m1;
            }
            
            res_cad = Convert.ToString(res);
            return res_cad;
        }
    }
}
