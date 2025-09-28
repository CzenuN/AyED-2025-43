using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Nuñez_Torrez_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("ingrese su numero");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = num; i >= 0; i--)
                Console.WriteLine("la cuenta regresiva desde su numero es: " + i);
            Console.ReadKey();
        }
    }
}