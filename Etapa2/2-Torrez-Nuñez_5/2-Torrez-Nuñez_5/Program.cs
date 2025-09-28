using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Torrez_Nuñez_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int objetos;
            Console.WriteLine("ingrese la cantidad de objetos: ");
            objetos = Convert.ToInt32(Console.ReadLine());
            int[] valor = new int[objetos];
            for (int i = 0; i < objetos; i++)
            {
                Console.WriteLine("ingrese el valor del objeto " + i + ":");
                valor[i] = int.Parse(Console.ReadLine());
            }
            Console.ReadKey();
        } 
    }
}
