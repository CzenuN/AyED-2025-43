using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codigobonito1._1
{
    class Program
    {
        static int suma(int Val1, int Val2)
        {
            return (Val1 + Val2);
        }
        static void Main(string[] args)
        {
            int result = suma(4, 6);
            Console.WriteLine(result);

            Console.ReadKey();
        }

        
    }
}
