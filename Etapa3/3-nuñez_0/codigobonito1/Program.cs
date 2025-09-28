using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codigobonito1
{
    class Program
    {
        static string saludo(string nombre)
        {
            return "Hola " + nombre ;
        }
        

        static void Main(string[] args)
        {

            string nom = Console.ReadLine();
            string mensaje = saludo(nom);
            Console.WriteLine(mensaje);
            Console.ReadKey();
        }

    }
}
