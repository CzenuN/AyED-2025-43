using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Nuñez_Torrez_12
{
    class Program
    {
        static void Main(string[] args)
        {
            string respuesta;
            do
            {
                Console.WriteLine("¿Quieres salir del programa? contesta SI si quieres salir");
                respuesta = Console.ReadLine();

            }
            while (respuesta != "SI");
            Console.WriteLine("Programa terminado");
            Console.ReadKey();
        }
    }
}

