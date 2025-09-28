using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Torrez_Nuñez_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int candidatos;
            Console.WriteLine("ingrese la cantidad de candidatos: ");
            candidatos = Convert.ToInt32(Console.ReadLine());
            int[] puntaje = new int[candidatos];
            for (int i = 0; i < candidatos; i++)
            {
                Console.WriteLine("El puntaje del candidato " + i + " es de: ");
                puntaje[i] = int.Parse(Console.ReadLine());
            }


            for (int i = 0; i < candidatos; i++)
            {
                for (int j = i + 1; j < candidatos; j++)
                {
                    if (puntaje[i] > puntaje[j])
                    {
                        int aux = puntaje[j];
                        puntaje[j] =puntaje[i];
                        puntaje[i] = aux;
                        

                    }
                }
            }
            Console.WriteLine("Ingrese un numero entero: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Los puntajes de menor a mayor son: ");
            for (int i = 0; i < candidatos; i++)
            {
                if (puntaje[i] % num == 0)
                {
                    Console.WriteLine(puntaje[i] + "");
                }
            }
            Console.ReadKey();
        }
    }
}
