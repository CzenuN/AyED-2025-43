using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el tamaño de la matriz (n): ");
        int n = int.Parse(Console.ReadLine());

        int[,] matriz = new int[n, n];
        int[] diagonal = new int[n];
        Random rand = new Random();

        // llenar matriz con números aleatorios
        Console.WriteLine("\nMatriz:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matriz[i, j] = rand.Next(1, 10); // números entre 1 y 9
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }

        // sacar diagonal principal
        for (int i = 0; i < n; i++)
        {
            diagonal[i] = matriz[i, i];
        }

        // mostrar diagonal
        Console.WriteLine("\nDiagonal principal:");
        for (int i = 0; i < n; i++)
        {
            Console.Write(diagonal[i] + " ");
        }

        Console.ReadKey();
    }
}
