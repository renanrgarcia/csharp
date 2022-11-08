using System;

// Crie um algoritmo que leia um número inteiro e informe se ele é par ou ímpar.

namespace Desafio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                char resposta = 's';
                while (resposta != 'n')
                {
                    Console.WriteLine("Esse programa informa se o número digitado é par ou ímpar.");
                    Console.Write("Digite um número inteiro: ");
                    int numero = int.Parse(Console.ReadLine());

                    if (numero % 2 == 0)
                        Console.WriteLine("O número {0} é par.", numero);
                    else
                        Console.WriteLine("O número {0} é ímpar.", numero);

                    Console.Write("Gostaria de executar o programa novamente (s/n)? ");
                    resposta = char.Parse(Console.ReadLine());
                    Console.Clear();
                }
                Console.WriteLine("Obrigado por utilizar o programa!");
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

