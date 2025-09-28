using System;

class Program
{
    static void Main()
    {
        const int MAX_POKHIMONS = 75;
        string[,] pochidex = new string[MAX_POKHIMONS, 6]; // Nombre, Tipo, Nivel, Estado, Investigador
        int cantidad = 0;
        Random rand = new Random();
        int opcion = 0;

        // Pochimons iniciales (1 Agua, 1 Fuego, 1 Planta)
        pochidex[0, 0] = "squirtle"; pochidex[0, 1] = "A"; pochidex[0, 2] = "10"; pochidex[0, 3] = "0"; pochidex[0, 4] = "0";
        pochidex[1, 0] = "chamander"; pochidex[1, 1] = "F"; pochidex[1, 2] = "12"; pochidex[1, 3] = "0"; pochidex[1, 4] = "0";
        pochidex[2, 0] = "bulbasaur"; pochidex[2, 1] = "P"; pochidex[2, 2] = "8"; pochidex[2, 3] = "0"; pochidex[2, 4] = "0";
        cantidad = 3;

        do
        {
            Console.Clear();
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Menú Principal - Centro de Investigación de Pochimons");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Pochimones Encontrados: " + cantidad + "/75\n");
            Console.WriteLine("1. Registrar Pochimon");
            Console.WriteLine("2. Asignar Investigador a Pochimon");
            Console.WriteLine("3. Actualizar Nivel de Pochimon");
            Console.WriteLine("4. Marcar Pochimon como Investigado");
            Console.WriteLine("5. Mostrar Información de Pochimons");
            Console.WriteLine("6. Buscar Pochimons por Tipo");
            Console.WriteLine("7. Mostrar Pochimons por Investigador");
            Console.WriteLine("8. Mostrar Pochimons Picados");
            Console.WriteLine("9. Salir");
            Console.Write("Ingrese la opción deseada: ");
            opcion = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (opcion)
            {
                case 1: // Registrar
                    if (cantidad >= MAX_POKHIMONS)
                    {
                        Console.WriteLine("La Pochidex está llena!");
                        break;
                    }
                    Console.Write("Ingrese el nombre del Pochimon: ");
                    pochidex[cantidad, 0] = Console.ReadLine();
                    Console.Write("Ingrese el tipo (A/F/P): ");
                    pochidex[cantidad, 1] = Console.ReadLine().ToUpper();
                    Console.Write("Ingrese el nivel: ");
                    pochidex[cantidad, 2] = Console.ReadLine();
                    pochidex[cantidad, 3] = "0"; // estado
                    pochidex[cantidad, 4] = "0"; // investigador
                    cantidad++;
                    Console.WriteLine("Pochimon registrado correctamente!");
                    break;

                case 2: // Asignar investigador
                    Console.WriteLine("Pochimons no investigados:");
                    for (int i = 0; i < cantidad; i++)
                    {
                        if (pochidex[i, 3] == "0")
                        {
                            Console.WriteLine($"{i + 1}. {pochidex[i, 0]} ({pochidex[i, 1]}) Nivel: {pochidex[i, 2]}");
                        }
                    }
                    Console.Write("Ingrese el número de fila: ");
                    int fila = int.Parse(Console.ReadLine()) - 1;
                    Console.Write("Ingrese código del investigador: ");
                    string cod = Console.ReadLine();
                    pochidex[fila, 4] = cod;
                    pochidex[fila, 3] = "1"; // estado en investigación
                    Console.WriteLine("Investigador asignado!");
                    break;

                case 3: // Actualizar nivel
                    Console.WriteLine("Pochimons registrados:");
                    for (int i = 0; i < cantidad; i++)
                    {
                        Console.WriteLine($"{i + 1}. {pochidex[i, 0]} Nivel: {pochidex[i, 2]}");
                    }
                    Console.Write("Ingrese fila del Pochimon: ");
                    fila = int.Parse(Console.ReadLine()) - 1;
                    int nivelActual = int.Parse(pochidex[fila, 2]);
                    int incremento = rand.Next(1, 4); // 1 a 3
                    nivelActual += incremento;
                    pochidex[fila, 2] = nivelActual.ToString();
                    Console.WriteLine($"{pochidex[fila, 0]} subió {incremento} niveles! Nuevo nivel: {nivelActual}");
                    break;

                case 4: // Marcar investigado
                    Console.WriteLine("Pochimons en investigación:");
                    for (int i = 0; i < cantidad; i++)
                    {
                        if (pochidex[i, 3] == "1")
                        {
                            Console.WriteLine($"{i + 1}. {pochidex[i, 0]} ({pochidex[i, 1]}) Nivel: {pochidex[i, 2]} Investigador: {pochidex[i, 4]}");
                        }
                    }
                    Console.Write("Ingrese fila del Pochimon a marcar investigado: ");
                    fila = int.Parse(Console.ReadLine()) - 1;
                    pochidex[fila, 3] = "2"; // investigado
                    Console.WriteLine($"{pochidex[fila, 0]} marcado como investigado!");
                    break;

                case 5: // Mostrar info
                    Console.WriteLine("Información de Pochimons:");
                    Console.WriteLine("Fila\tNombre\tTipo\tNivel\tEstado\tInvestigador");
                    for (int i = 0; i < cantidad; i++)
                    {
                        Console.WriteLine($"{i + 1}\t{pochidex[i, 0]}\t{pochidex[i, 1]}\t{pochidex[i, 2]}\t{pochidex[i, 3]}\t{pochidex[i, 4]}");
                    }
                    break;

                case 6: // Buscar por tipo
                    Console.Write("Ingrese tipo (A/F/P): ");
                    string tipo = Console.ReadLine().ToUpper();
                    Console.WriteLine("Pochimons encontrados:");
                    for (int i = 0; i < cantidad; i++)
                    {
                        if (pochidex[i, 1] == tipo)
                        {
                            Console.WriteLine($"{i + 1}. {pochidex[i, 0]} Nivel: {pochidex[i, 2]} Estado: {pochidex[i, 3]}");
                        }
                    }
                    break;

                case 7: // Pochimons por investigador
                    Console.Write("Ingrese código del investigador: ");
                    string investigador = Console.ReadLine();
                    Console.WriteLine("Pochimons asignados:");
                    for (int i = 0; i < cantidad; i++)
                    {
                        if (pochidex[i, 4] == investigador)
                        {
                            Console.WriteLine($"{i + 1}. {pochidex[i, 0]} ({pochidex[i, 1]}) Nivel: {pochidex[i, 2]} Estado: {pochidex[i, 3]}");
                        }
                    }
                    break;

                case 8: // Picados
                    Console.WriteLine("Pochimons Picados (Nivel > 30):");
                    for (int i = 0; i < cantidad; i++)
                    {
                        if (int.Parse(pochidex[i, 2]) > 30)
                        {
                            Console.WriteLine($"{i + 1}. {pochidex[i, 0]} ({pochidex[i, 1]}) Nivel: {pochidex[i, 2]}");
                        }
                    }
                    break;

                case 9:
                    Console.WriteLine("Saliendo del programa...");
                    break;

                default:
                    Console.WriteLine("Opción inválida!");
                    break;
            }

            if (opcion != 9)
            {
                Console.WriteLine("\nPresione una tecla para continuar...");
                Console.ReadKey();
            }

        } while (opcion != 9);
    }
}
