using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nñz_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;
            int ingreso;
            bool cobrar = false;
            Console.Write("su edad es: ");
            edad = Convert.ToInt32(Console.ReadLine());
            Console.Write("tus ingresos mensuales son: ");
            ingreso = Convert.ToInt32(Console.ReadLine());

            if (edad > 19 && ingreso >= 100000)
            {
                cobrar = true;

            }
            else if (edad < 19 && ingreso = 0)
            {
                cobrar = true;

            }
            else if (edad == 19 && ingreso <= 50000)
            {
                cobrar = true;

            }
            Console.WriteLine(cobrar ? "usted puedecobrar la beca" : "usted no puede cobrar la beca");
            Console.ReadKey();

        }
    }
}
