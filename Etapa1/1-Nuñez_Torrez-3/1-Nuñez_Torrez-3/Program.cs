using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            Console.WriteLine("Introduzca un numero entero");
            num1 = Convert.ToInt32(Console.ReadLine());
            if (num1 % 2 == 0)
            {
                Console.WriteLine("su numero es par");
            }
            else
            {
                Console.WriteLine("su numero es impar");
            }
            Console.ReadKey();

        }
    }
}
