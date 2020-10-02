using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome1, nome2;

            Console.WriteLine("Escreva um primeiro nome: ");
            nome1 = (Console.ReadLine());

            Console.WriteLine("Escreva um segundo nome: ");
            nome2 = (Console.ReadLine());

            Console.WriteLine(nome1 + " em maisculo " + nome1.ToUpper());
            Console.WriteLine(nome1 + " possui " + nome1.Length + " caracteres ");
            Console.WriteLine("os três primeiros caracteres de " + nome1 + " são: "+nome1.Substring(0,3));
            
            Console.WriteLine(nome2 + " em maisculo " + nome2.ToUpper());
            Console.WriteLine(nome2 + " possui " + nome2.Length + " caracteres ");
            Console.WriteLine("os três primeiros caracteres de " + nome2 + " são: " + nome2.Substring(0, 3));
            
            Console.ReadKey();
        }
    }
}
