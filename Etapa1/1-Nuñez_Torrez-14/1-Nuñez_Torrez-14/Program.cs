using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Nuñez_Torrez_14
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre = "Jugador 1";
            int salud = 100;
            int monedas = 50;
            int enemigos = 0;
            bool Espada = false;
            bool salida = false;

            do
            {
                Console.WriteLine("============ SIMULADOR GAMER ============");
                Console.WriteLine("1. Mostrar estado del jugador");
                Console.WriteLine("2. Encontrar espada mágica");
                Console.WriteLine("3. Pelear contra un enemigo");
                Console.WriteLine("4. Comprar poción de vida (vale 20 monedas)");
                Console.WriteLine("5. Salir del juego");

                int opc = Convert.ToInt32(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        Console.WriteLine(" Estado del " + nombre);
                        Console.WriteLine(" Salud = " + salud);
                        Console.WriteLine(" Monedas = " + monedas);
                        Console.WriteLine(" Enemigos derrotados = " + enemigos);
                        Console.WriteLine(" Espada = " + Espada);
                        break;
                    case 2:
                        Console.WriteLine("ingres un numero:");
                        if (Espada == true)
                        {
                            Console.WriteLine("Usted ya tiene la espada");
                        }
                        else
                        {
                            Console.WriteLine("¡Felicidades! Encontraste la espada!");
                            Espada = true;
                        }

                        break;

                    case 3:
                        if (Espada == true)
                        {
                            Console.WriteLine("¡Ganaste la batalla! Salud -10.");
                            salud = salud - 10;
                            enemigos = enemigos + 1;

                        }
                        else
                        {
                            Console.WriteLine("¡Fue una pelea dura sin espada! Salud -30.");
                            salud = salud - 30;
                        }
                        break;
                    case 4:
                        if (monedas < 20)
                        {
                            Console.WriteLine("¡No tenés suficientes monedas!.");

                        }
                        else
                        {
                            Console.WriteLine("Usaste una poción. +20 de salud.");
                            monedas = monedas - 20;
                            salud = salud + 20;
                        }

                        break;
                    case 5:
                        Console.WriteLine("Saliste del juego");
                        salida = true;
                        break;
                }
            } while (!salida);
            Console.ReadKey();
        }
    }
}
