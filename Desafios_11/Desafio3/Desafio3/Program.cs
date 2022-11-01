using System;
using System.Globalization;

// Crie um algoritmo que leia um número e alerte quando o mesmo estiver entre -100 e 100.

namespace Desafio3 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Esse sistema alerta se o número informado está entre -100 e 100.");
            Console.Write("Digite um número: ");
            double n = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (n >= -100.0 && n <= 100.0)
                Console.WriteLine($"O número é {n} e está entre -100 e 100.");
            else
                Console.WriteLine($"O número é {n} não está entre -100 e 100.");

        }
    }
}