using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Nuñez_Torres_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("n es igual a: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
                if (i % 2 == 0)
                {
                    Console.WriteLine("su listado desde 0 a n (mostrando solo numeros par) seria: " + i);
                }
                else
                {
                    Console.WriteLine("error");
                }
            Console.ReadKey();

        }

    }
}

