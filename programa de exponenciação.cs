using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero, resultado;

            Console.WriteLine("Digite o número desejado: ");
            numero = double.Parse(Console.ReadLine());

            resultado = Math.Pow(numero,2);
            Console.WriteLine("Resultado: " + resultado);
            Console.ReadKey();
        }
    }
}
