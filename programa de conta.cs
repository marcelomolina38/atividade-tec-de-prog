using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int w, x, y, z,res;

            Console.WriteLine("Informe o valor de W: ");
            w = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor de X: ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor de Y: ");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor de Z:");
            z = int.Parse(Console.ReadLine());
            Console.Write(((x >= y) && (z <= x)) || ((x == w) && (y == z) || (!(x != w))));
            Console.ReadKey();
        }
    }
}
