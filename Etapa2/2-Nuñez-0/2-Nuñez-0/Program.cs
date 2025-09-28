using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Nuñez_0
{
    class Program
    {
        static void Main(string[] args)
        {
            int Invitados;

            while (true)
            {
                Console.Write("Ingrese la cantidad de invitados (de 1 a 100): ");
                if (int.TryParse(Console.ReadLine(), out Invitados) && Invitados > 0 && Invitados <= 100)
                {
                    break;
                }
                Console.WriteLine("Entrada inválida. Ingrese un número entero entre de 1 a 100.");
            }

            double[] consumoComida = new double[Invitados];
            double sumaconsumo = 0;

            for (int i = 0; i < Invitados; i++)
            {
                while (true)
                {
                    Console.Write($"Ingrese el consumo de comida del invitado {i + 1}: ");
                    if (double.TryParse(Console.ReadLine(), out consumoComida[i]) && consumoComida[i] >= 1 && consumoComida[i] <= 100)
                    {
                        sumaconsumo += consumoComida[i];
                        break;
                    }
                    Console.WriteLine("Entrada inválida. Ingrese un número decimal entre de 1 a 100.");
                }
            }

            double promediocomida = sumaconsumo / Invitados;
            Console.WriteLine($"\nEl promedio de consumo de comida por invitado es: {promediocomida}");

            Console.ReadKey();
        }
    }
}

