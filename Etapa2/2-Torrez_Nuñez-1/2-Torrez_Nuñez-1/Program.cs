using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Torrez_Nuñez_1
{
    public static void Main(string[] args)
    {
        Console.WriteLine("¡Bienvenido al registro de tiempos de Rayo McQueen!");

        int numVueltas;

        Console.Write("Ingrese el número de vueltas completadas: ");
        while (!int.TryParse(Console.ReadLine(), out numVueltas) || numVueltas <= 0)
        {
            Console.WriteLine("Entrada inválida. Ingrese un número entero positivo.");
            Console.Write("Ingrese el número de vueltas completadas: ");
        }


        double[] tiemposVuelta = new double[numVueltas];

        for (int i = 0; i < numVueltas; i++)
        {
            Console.Write($"Ingrese el tiempo de la vuelta {i + 1} (en segundos): ");
            while (!double.TryParse(Console.ReadLine(), out tiemposVuelta[i]) || tiemposVuelta[i] <= 0)
            {
                Console.WriteLine("Entrada inválida. Ingrese un número decimal positivo.");
                Console.Write($"Ingrese el tiempo de la vuelta {i + 1} (en segundos): ");
            }
        }
        double tiempoTotal = 0;
        for (int i = 0; i < numVueltas; i++)
        {
            tiempoTotal += tiemposVuelta[i];
        }
        double promedioTiempo = tiempoTotal / numVueltas;

        double mejorVuelta = tiemposVuelta[0];
        for (int i = 1; i < numVueltas; i++)
        {
            if (tiemposVuelta[i] < mejorVuelta)
            {
                mejorVuelta = tiemposVuelta[i];
            }
        }

        Console.WriteLine("\n--- Resultados ---");
        Console.WriteLine($"Tiempo total de la carrera: {tiempoTotal:F2} segundos");
        Console.WriteLine($"Promedio de tiempo por vuelta: {promedioTiempo:F2} segundos");
        Console.WriteLine($"Mejor vuelta: {mejorVuelta:F2} segundos");
        Console.ReadKey();
    }
}