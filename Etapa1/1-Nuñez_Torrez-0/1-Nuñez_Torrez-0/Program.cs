using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;
            Console.WriteLine("Ingrese su edad: ");
            edad = Convert.ToInt32(Console.ReadLine());
            if (edad > 18)
            {
                Console.WriteLine("Eres mayor");
            }
            else
            {
                Console.WriteLine("Eres menor");
            }
            Console.ReadKey();

        }
    }
}

