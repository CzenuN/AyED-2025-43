using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace torrez_nuñez8
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;
            Console.WriteLine("¿Cual es su edad?");
            edad = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < edad; i++)
                Console.WriteLine("todos los años que cumpliste de edad fueron: " + i);
            Console.ReadKey();


        }
    }
}
