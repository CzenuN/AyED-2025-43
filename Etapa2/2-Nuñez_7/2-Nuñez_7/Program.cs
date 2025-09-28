using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el tamaño del vector: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] vector = new int[n];
        Random rand = new Random();

        // llenar el vector con números aleatorios entre 1 y 100
        for (int i = 0; i < n; i++)
        {
            vector[i] = rand.Next(1, 101);
        }

        int opcion = 0;

        while (opcion != 4)
        {
            Console.WriteLine("\n--- Menú ---");
            Console.WriteLine("1. Mostrar vector");
            Console.WriteLine("2. Buscar un número");
            Console.WriteLine("3. Ordenar vector");
            Console.WriteLine("4. Salir");
            Console.Write("Elija una opción: ");

            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Elementos del vector:");
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write(vector[i] + " ");
                    }
                    Console.WriteLine();
                    break;

                case 2:
                    Console.Write("Ingrese el número a buscar: ");
                    int num = Convert.ToInt32(Console.ReadLine());
                    bool encontrado = false;
                    for (int i = 0; i < n; i++)
                    {
                        if (vector[i] == num)
                        {
                            Console.WriteLine($"Número encontrado en la posición {i}");
                            encontrado = true;
                            break;
                        }
                    }
                    if (!encontrado)
                    {
                        Console.WriteLine("El número no está en el vector.");
                    }
                    break;

                case 3:
                    Console.WriteLine("1. Ascendente");
                    Console.WriteLine("2. Descendente");
                    int tipo = Convert.ToInt32(Console.ReadLine());

                    if (tipo == 1)
                    {
                        Array.Sort(vector);
                        Console.WriteLine("Vector ordenado de forma ascendente.");
                    }
                    else if (tipo == 2)
                    {
                        Array.Sort(vector);
                        Array.Reverse(vector);
                        Console.WriteLine("Vector ordenado de forma descendente.");
                    }
                    else
                    {
                        Console.WriteLine("Opción inválida.");
                    }
                    break;

                case 4:
                    Console.WriteLine("Saliendo del programa...");
                    break;

                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }
            Console.ReadKey();
        }
    }
}
