using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_Nuñez_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Edad: ");
            int edad = int.Parse(Console.ReadLine());
            Console.WriteLine($"Hola {nombre}, tu edad es {edad}");

            Console.ReadKey();
        }
    }
}

