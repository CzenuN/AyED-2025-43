using System;

namespace nuñez7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su palabra");
            string palabra = Console.ReadLine();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(palabra);
            }

            Console.ReadKey();
        }
    }
}