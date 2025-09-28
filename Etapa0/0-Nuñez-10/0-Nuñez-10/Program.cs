using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_Nuñez_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int grados_c;
            Console.WriteLine("introduci los grados celsius: ");
            grados_c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(+grados_c + "grados celsius a kelvin: " + (grados_c + 273.15));
            Console.WriteLine(+grados_c + "grados celsius a fahrenheit: " + ((grados_c * 9 / 5) + 32));
            Console.ReadKey();
        }
    }
}

