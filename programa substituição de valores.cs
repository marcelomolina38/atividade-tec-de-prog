using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Digite o valor de A: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de B: ");
            b = int.Parse(Console.ReadLine());
            c = a;
            a = b;
            b = c;
            Console.WriteLine("Valor de A: " + a);
            Console.WriteLine("Valor de B: " + b);
            Console.ReadKey();
        }
    }
}
