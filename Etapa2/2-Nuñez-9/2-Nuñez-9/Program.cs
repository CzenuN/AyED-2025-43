using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Nuñez_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m;

            while (true)
            {
                Console.Write("Ingrese el número de filas (n): ");
                if (int.TryParse(Console.ReadLine(), out n) && n > 0)
                {
                    break;
                }
                Console.WriteLine("Entrada inválida. Ingrese un número entero positivo.");
            }

            while (true)
            {
                Console.Write("Ingrese el número de columnas (m): ");
                if (int.TryParse(Console.ReadLine(), out m) && m > 0)
                {
                    break;
                }
                Console.WriteLine("Entrada inválida. Ingrese un número entero positivo.");
            }

            int[,] matriz = new int[n, m];

            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matriz[i, j] = random.Next(1, 101);
                }
            }

            Console.WriteLine("\nMatriz:");
            ImprimirMatriz(matriz);
        }

        static void ImprimirMatriz(int[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}

