using System;
public class nuñezytorrez
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Bienvenido al torneo de Galaxy Quest!");

        int numParticipantes;

        Console.Write("Ingrese la cantidad de participantes: ");
        while (!int.TryParse(Console.ReadLine(), out numParticipantes) || numParticipantes <= 0)
        {
            Console.WriteLine("Entrada inválida. Ingrese un número entero positivo.");
            Console.Write("Ingrese la cantidad de participantes: ");
        }

        int[] puntajes = new int[numParticipantes];

        for (int i = 0; i < numParticipantes; i++)
        {
            Console.Write($"Ingrese el puntaje del participante {i + 1}: ");
            while (!int.TryParse(Console.ReadLine(), out puntajes[i]) || puntajes[i] < 0)
            {
                Console.WriteLine("Entrada inválida. Ingrese un número entero no negativo.");
                Console.Write($"Ingrese el puntaje del participante {i + 1}: ");
            }
        }

        Array.Sort(puntajes);
        Array.Reverse(puntajes);

        Console.WriteLine("\n--- Resultados del Torneo ---");
        Console.WriteLine("Puntajes ordenados (de mayor a menor):");
        for (int i = 0; i < numParticipantes; i++)
        {
            Console.WriteLine($"Participante {i + 1}: {puntajes[i]} puntos");
        }

        Console.WriteLine($"\nPrimer lugar: {puntajes[0]} puntos");
        Console.WriteLine($"Último lugar: {puntajes[numParticipantes - 1]} puntos");
        Console.ReadKey();
    }
}
