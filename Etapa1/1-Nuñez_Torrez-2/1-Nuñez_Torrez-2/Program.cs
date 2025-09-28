using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2;
            Console.WriteLine("Ingrese su primer numero");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese su segundo numero");
            numero2 = Convert.ToInt32(Console.ReadLine());
            if (numero2 == 0)
            {
                Console.WriteLine("error");
            }
            else
            {
                Console.WriteLine("su division es: " + (numero1 / numero2);
            }
            Console.ReadKey();

        }
    }
}