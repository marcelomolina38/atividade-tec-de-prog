using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_8
{
    class Program
    {
        static void Main(string[] args)
        {
            double reais, res, euro;

            Console.WriteLine("Digite o valor em reais desejado: ");
            reais = double.Parse(Console.ReadLine());

            res = reais * 5.39;
            Console.WriteLine("{0} reais da no total {1:N} dolares.", reais, res);
            
            Console.WriteLine("Digite o valor em reais desejado: ");
            euro = double.Parse(Console.ReadLine());

            res = reais * 6.38;
            Console.WriteLine("{0} reais da no total {1:N} euros.", reais, res);
            Console.ReadKey();
        }
    }
}
