using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Nuñez_Torrez_10
{
    static void Main()
    {
        for (int i = 1; i <= 100; i++)
            Console.WriteLine(
                (i % 3 == 0 && i % 5 == 0) ? "fizzbuzz" :
                (i % 3 == 0) ? "fizz" :
                (i % 5 == 0) ? "buzz" : "" + i
            );

        Console.ReadKey();
    }
}
