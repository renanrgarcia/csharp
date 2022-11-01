using System;

// Crie um algoritmo que leia um número inteiro e informe se ele é ou não divisível por 7.

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Esse programa informa se o número digitado é divisível por 7.");
            Console.Write("Digite um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 7 == 0)
                Console.WriteLine("O número " + numero + " é divisível por 7.");
            else
                Console.WriteLine("O número " + numero + " não é divisível por 7.");

        }
    }
}