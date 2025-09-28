using System;
class Program
{
    static void Main()
    {
        int opcion = 0;

        while (opcion != 4)
        {
            Console.WriteLine("\n=== Menú ===");
            Console.WriteLine("1. Saludar");
            Console.WriteLine("2. Sumar 2 + 2");
            Console.WriteLine("3. Mostrar la hora actual");
            Console.WriteLine("4. Salir");
            Console.Write("Elige una opción: ");

            opcion = Convert.ToInt32(Console.ReadLine());

            if (opcion == 1)
            {
                Console.WriteLine("¡Hola!");
            }
            else if (opcion == 2)
            {
                Console.WriteLine("2 + 2 = 4");
            }
            else if (opcion == 3)
            {
                Console.WriteLine("La hora actual es: " + DateTime.Now.ToShortTimeString());
            }
            else if (opcion == 4)
            {
                Console.WriteLine("Chau, gracias por usar el programa!");
            }
            else
            {
                Console.WriteLine("Opción inválida, intenta otra vez.");
            }
            Console.ReadKey();
        }
    }
}
