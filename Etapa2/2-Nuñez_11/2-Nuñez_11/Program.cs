using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el tamaño de la matriz (n): ");
        int n = int.Parse(Console.ReadLine());

        int[,] matriz = new int[n, n];
        int[,] rotada = new int[n, n];

        // Cargar la matriz
        Console.WriteLine("Cargar la matriz:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"matriz[{i},{j}]: ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // Rotar 90° horario
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                rotada[j, n - 1 - i] = matriz[i, j];
            }
        }

        // Mostrar matriz rotada
        Console.WriteLine("\nMatriz rotada 90°:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(rotada[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.ReadKey();
    }
}
