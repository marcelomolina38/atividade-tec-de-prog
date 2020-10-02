using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_6
{
    class Program
    {
        static void Main(string[] args)
        {
            double reais, res;

            Console.WriteLine("Digite o valor em reais desejado: ");
            reais = double.Parse(Console.ReadLine());

            res = reais * 5.39;
            Console.WriteLine("{0} reais da no total {1:N} dolares.", reais, res);
            Console.ReadKey();
        }
    }
}
