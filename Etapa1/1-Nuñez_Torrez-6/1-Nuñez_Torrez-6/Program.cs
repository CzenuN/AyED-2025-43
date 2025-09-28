using System;

namespace torrez
{
    class Program
    {
        static void Main(string[] args)
        {
            int celsius;
            Console.WriteLine("ingrese la temperatura a grados celsius: ");
            celsius = Convert.ToInt32(Console.ReadLine());
            if (celsius <= 0)
            {
                Console.WriteLine("se congela");
            }
            else if (celsius >= 100)
            {
                Console.WriteLine("hierve");
            }
            else if (celsius <= 99)
            {
                Console.WriteLine("es liquido");
            }
            Console.ReadKey();
        }

    }

}