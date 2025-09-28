using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Torrez_Nuñez_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al torneo de Galaxy Quest!");

            int numParticipantes;
            Console.Write("Ingrese la cantidad de participantes: ");
            numParticipantes = Convert.ToInt32(Console.ReadLine());


            int[] puntajes = new int[numParticipantes];
            for (int i = 0; i < numParticipantes; i++)
            {
                Console.Write($"Ingrese el puntaje del participante {i + 1}: ");
                puntajes[i] = Convert.ToInt32(Console.ReadLine());



            }

            var orderedScores = puntajes.OrderByDescending(p => p).ToArray();

            Console.WriteLine("\n--- Resultados del Torneo ---");
            Console.WriteLine("Puntajes ordenados (de mayor a menor):");
            for (int i = 0; i < numParticipantes; i++)
            {
                Console.WriteLine($"Participante {i + 1}: {orderedScores[i]} puntos");
            }

            Console.WriteLine($"\nPrimer lugar: {orderedScores[0]} puntos");
            Console.WriteLine($"Último lugar: {orderedScores[numParticipantes - 1]} puntos");
            Console.ReadKey();
        }
    }