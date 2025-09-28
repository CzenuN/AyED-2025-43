using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_Nuñez_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Radio: ");
            double radio = double.Parse(Console.ReadLine());
            double superficie = 4 * Math.PI * radio * radio;
            double volumen = (4.0 / 3.0) * Math.PI * radio * radio * radio;
            Console.WriteLine($"Superficie: {superficie}");
            Console.WriteLine($"Volumen: {volumen}");

            Console.ReadKey();
        }
    }
}

