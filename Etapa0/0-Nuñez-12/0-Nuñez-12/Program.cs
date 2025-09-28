using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_Nuñez_12
{
    class Program
    {
        static void Main(string[] args)
        {
            string letra1;
            string letra2;
            string letra3;
            Console.WriteLine("introduci una letra: ");
            letra1 = Console.ReadLine();
            Console.WriteLine("introduci otra letra: ");
            letra2 = Console.ReadLine();
            Console.WriteLine("introduci otra letra mas: ");
            letra3 = Console.ReadLine();
            Console.WriteLine(letra3 + letra2 + letra1);
            Console.ReadKey();

        }
    }
}