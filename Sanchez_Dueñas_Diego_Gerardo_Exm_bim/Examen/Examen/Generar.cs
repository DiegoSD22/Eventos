using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Generar
    {
        public static string[] nums = new string[100];
        public static void Crear_Aleatorios()
        {



            Random rm = new Random();

            for (int i = 0; i <= 99; i++)
            {


                nums[i] = Convert.ToString(rm.Next(100));

            }

        }
    }
}
