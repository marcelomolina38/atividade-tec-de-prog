using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, res;

            Console.Write("Digite o número desejado: ");
            numero = int.Parse(Console.ReadLine());
            res = numero * 2;

            Console.Write("Resultado: "+res);

            Console.ReadKey();
        }
    }
}
