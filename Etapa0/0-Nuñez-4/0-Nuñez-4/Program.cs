using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_Nuñez_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese su primer número: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Ingrese su segundo número: ");
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine($"Suma: {num1 + num2}");

            Console.ReadKey();
        }
    }
}

