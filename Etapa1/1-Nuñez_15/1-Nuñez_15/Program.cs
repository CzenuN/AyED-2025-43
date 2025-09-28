using System;

class Program
{
    static void Main()
    {
        // Variables iniciales
        int salud = 100;
        int hambre = 50;
        int energia = 70;
        int dia = 1;
        bool sigueVivo = true;
        Random rand = new Random();

        Console.WriteLine("Bienvenido a 'Sobreviví una semana en una isla'");
        Console.WriteLine("Tenés que sobrevivir durante 7 días.\n");

        while (sigueVivo && dia <= 7)
        {
            Console.WriteLine($"\n=== Día {dia} ===");
            Console.WriteLine("¿Qué querés hacer?");
            Console.WriteLine("1. Buscar comida");
            Console.WriteLine("2. Dormir");
            Console.WriteLine("3. Explorar la isla");
            Console.WriteLine("4. Ver estado del personaje");
            Console.WriteLine("5. Salir del juego");
            Console.Write("Elegí una opción: ");

            int opcion;
            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Opción inválida.");
                continue;
            }

            Console.WriteLine();

            switch (opcion)
            {
                case 1: // Buscar comida
                    hambre += 20;
                    energia -= 15;
                    Console.WriteLine("Buscaste comida. Hambre +20, Energía -15.");
                    int probComida = rand.Next(1, 101);
                    if (probComida <= 30)
                    {
                        salud -= 15;
                        Console.WriteLine("Comiste algo en mal estado. Salud -15.");
                    }
                    break;

                case 2: // Dormir
                    energia += 30;
                    hambre -= 10;
                    Console.WriteLine("Dormiste bien. Energía +30, Hambre -10.");
                    break;

                case 3: // Explorar
                    energia -= 20;
                    hambre -= 15;
                    Console.WriteLine("Exploraste la isla. Energía -20, Hambre -15.");
                    int probExplorar = rand.Next(1, 101);
                    if (probExplorar <= 50)
                    {
                        salud += 10;
                        Console.WriteLine("Encontraste una planta curativa! Salud +10.");
                    }
                    break;

                case 4: // Ver estado
                    Console.WriteLine("Estado del personaje:");
                    Console.WriteLine($"Salud: {salud}");
                    Console.WriteLine($"Hambre: {hambre}");
                    Console.WriteLine($"Energía: {energia}");
                    continue; // no avanza el día

                case 5: // Salir
                    Console.WriteLine("Decidiste abandonar el juego");
                    sigueVivo = false;
                    break;

                default:
                    Console.WriteLine("Opción inválida.");
                    continue;
            }

            // Chequear condiciones de muerte (excepto ver estado)
            if (salud <= 0 || hambre <= 0 || energia <= 0)
            {
                Console.WriteLine("Te desmayaste y no pudiste sobrevivir... Game Over.");
                sigueVivo = false;
            }
            else if (opcion != 4) // solo avanza el día si no es "Ver estado"
            {
                dia++;
            }
        }

        if (sigueVivo && dia > 7)
        {
            Console.WriteLine("\n¡Sobreviviste los 7 días en la isla! ¡Ganaste el juego!");
        }

        Console.WriteLine("\nFin del juego.");

        Console.ReadKey();
    }
}
