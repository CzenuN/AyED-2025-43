using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_Nuñez_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            Console.WriteLine("introdusca el ancho de un rectangulo: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("introdusca la altura: ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("el perimetros de ese rectangulo es: " + (2 * x + 2 * y));
            Console.WriteLine("el area de ese rectangulo es: " + (x * y));
            Console.WriteLine("el diagonal de ese rectangulo es: " + (Math.Sqrt(x * x + y * y)));
            Console.ReadKey();

        }
    }
}