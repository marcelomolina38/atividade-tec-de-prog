using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;
            string nome, cidade;

            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.Write("Digite sua idade: ");
            idade = int.Parse(Console.ReadLine());

            Console.Write("Digite sua cidade: ");
            cidade = Console.ReadLine();

            Console.WriteLine("Nome:" + nome);
            Console.WriteLine("Idade:" + idade);
            Console.WriteLine("cidade:" + cidade);

            Console.ReadKey();
        }
    }
}
