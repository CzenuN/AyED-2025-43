using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_Nuñez_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Dividendo: ");
            int dividendo = int.Parse(Console.ReadLine());
            Console.Write("Divisor: ");
            int divisor = int.Parse(Console.ReadLine());
            Console.WriteLine($"Resto: {dividendo % divisor}");

            Console.ReadKey();
        }
    }
}
