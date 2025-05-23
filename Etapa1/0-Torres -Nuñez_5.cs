using System;

namespace nñz_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string comida;
            string refugio;
            string bate;
            Console.WriteLine("Tiene comida?");
            comida = Console.ReadLine();
            Console.WriteLine("tiene refugio?");
            refugio = Console.ReadLine();
            Console.WriteLine("tiene bate?");
            bate = Console.ReadLine();

            bool sobrevive = (refugio == "si") && (comida == "si") && (bate == "si");
            if (sobrevive)
            {
                Console.WriteLine("sobrevive");
            }
            else
            {
                Console.WriteLine("no sobrevive");
            }
            Console.ReadKey();
        }
    }
}
