using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el tamaño de la matriz (n): ");
        int n = int.Parse(Console.ReadLine());

        int[,] m1 = new int[n, n];
        int[,] m2 = new int[n, n];
        int[,] suma = new int[n, n];

        // Cargar matriz 1
        Console.WriteLine("Cargar matriz 1:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"m1[{i},{j}]: ");
                m1[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // Cargar matriz 2
        Console.WriteLine("Cargar matriz 2:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"m2[{i},{j}]: ");
                m2[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // Sumar matrices
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                suma[i, j] = m1[i, j] + m2[i, j];
            }
        }

        // Mostrar resultado
        Console.WriteLine("Matriz suma:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(suma[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.ReadKey();
    }
}
