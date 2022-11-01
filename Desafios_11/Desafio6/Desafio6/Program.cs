using System;

// Crie um algoritmo que leia um número inteiro e informe se ele é par ou ímpar.

namespace Desafio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Esse programa informa se o número digitado é par ou ímpar.");
            Console.Write("Digite um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
                Console.WriteLine("O número {0} é par.", numero);
            else
                Console.WriteLine("O número {0} é ímpar.", numero);
        }
    }
}

