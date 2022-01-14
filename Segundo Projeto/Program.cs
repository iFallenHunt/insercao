using Humanizer;
using System;

namespace SegundoProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Qual o seu nome completo? ");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa? ");
            int quartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o preço de algum poduto (separado por ,)");
            double prod = double.Parse(Console.ReadLine());


            Console.WriteLine("Insira seu Sobrenome, idade e altura (tudo na mesma linha)");

            string[] completo = Console.ReadLine().Split(' ');
            string snome = completo[0];
            int idade = int.Parse(completo[1]);
            double altura = double.Parse(completo[2]);

            Console.WriteLine("O meu nome é: ");
            Console.WriteLine(nome);
            Console.WriteLine("A minha casa tem: ");
            Console.WriteLine(quartos);
            Console.WriteLine("O produto custa: ");
            Console.WriteLine(prod);

            Console.WriteLine("O meu sobrenome é: ");
            Console.WriteLine(snome);
            Console.WriteLine("A minha idade é: ");
            Console.WriteLine(idade);
            Console.WriteLine("A minha altura é: ");
            Console.WriteLine(altura);


        }
    }
}