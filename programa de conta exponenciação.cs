using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, res;

            Console.WriteLine("Digite o valor de A: ");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de B: ");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de C: ");
            c = double.Parse(Console.ReadLine());
            res = Math.Pow(a,2) *5 - c / (b - a % 4);
            Console.WriteLine("Resultado: {0:N}", res);

            Console.ReadKey();
        }
    }
}
