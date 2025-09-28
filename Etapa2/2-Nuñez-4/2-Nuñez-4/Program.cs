using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Nuñez_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la cantidad de productos vendidos durante el Hot Sale: ");
            int cantidadproductos = int.Parse(Console.ReadLine());

            double preciomaximo = double.MinValue;
            double preciominimo = double.MaxValue;

            for (int i = 0; i < cantidadproductos; i++)
            {
                Console.Write($"Precio del producto {i + 1}: ");
                double precio = double.Parse(Console.ReadLine());
                preciomaximo = Math.Max(preciomaximo, precio);
                preciominimo = Math.Min(preciominimo, precio);
            }

            Console.WriteLine($"\nPrecio más alto: {preciomaximo}");
            Console.WriteLine($"Precio más bajo: {preciominimo}");
            Console.ReadKey();
        }
    }
}
