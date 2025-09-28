using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Torrez_Nuñez_2
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Bienvenido al sistema de evaluación de Phineas y Ferb!");

        int numTPs, numExamenes;

        Console.Write("Ingrese la cantidad de Trabajos Prácticos (TPs): ");
        while (!int.TryParse(Console.ReadLine(), out numTPs) || numTPs <= 0)
        {
            Console.WriteLine("Entrada inválida. Ingrese un número entero positivo.");
            Console.Write("Ingrese la cantidad de Trabajos Prácticos (TPs): ");
        }

        Console.Write("Ingrese la cantidad de exámenes: ");
        while (!int.TryParse(Console.ReadLine(), out numExamenes) || numExamenes <= 0)
        {
            Console.WriteLine("Entrada inválida. Ingrese un número entero positivo.");
            Console.Write("Ingrese la cantidad de exámenes: ");
        }

        double[] notasTPs = new double[numTPs];
        double[] notasExamenes = new double[numExamenes];

        for (int i = 0; i < numTPs; i++)
        {
            Console.Write($"Ingrese la nota del TP {i + 1} (0-10): ");
            while (!double.TryParse(Console.ReadLine(), out notasTPs[i]) || notasTPs[i] < 0 || notasTPs[i] > 10)
            {
                Console.WriteLine("Entrada inválida. Ingrese un número entre 0 y 10.");
                Console.Write($"Ingrese la nota del TP {i + 1} (0-10): ");
            }
        }

        for (int i = 0; i < numExamenes; i++)
        {
            Console.Write($"Ingrese la nota del examen {i + 1} (0-10): ");
            while (!double.TryParse(Console.ReadLine(), out notasExamenes[i]) || notasExamenes[i] < 0 || notasExamenes[i] > 10)
            {
                Console.WriteLine("Entrada inválida. Ingrese un número entre 0 y 10.");
                Console.Write($"Ingrese la nota del examen {i + 1} (0-10): ");
            }
        }

        double promedioExamenes = 0;
        for (int i = 0; i < numExamenes; i++)
        {
            promedioExamenes += notasExamenes[i];
        }
        promedioExamenes /= numExamenes;

        int tpsAprobados = 0;
        for (int i = 0; i < numTPs; i++)
        {
            if (notasTPs[i] >= 6)
            {
                tpsAprobados++;
            }
        }

        bool aprobo = promedioExamenes >= 6 && (double)tpsAprobados / numTPs >= 0.75;

        Console.WriteLine("\n--- Resultados ---");
        Console.WriteLine($"Promedio de exámenes: {promedioExamenes:F2}");
        Console.WriteLine($"Porcentaje de TPs aprobados: {(double)tpsAprobados / numTPs * 100:F2}%");
        Console.WriteLine(aprobo ? "Phineas y Ferb pueden aprobar la materia!" : "Phineas y Ferb no pueden aprobar la materia");
        Console.ReadKey();
    }
}
