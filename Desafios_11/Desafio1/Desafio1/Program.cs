using System;
using System.Globalization;

// Crie um algoritmo que leia um número e alerte quando o mesmo for maior do que 500.

namespace Desafio1 
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Esse programa responde se o número digitado é maior do que 500.");
            Console.Write("Digite um número: ");
            double n = double.Parse(Console.ReadLine().ToString(CultureInfo.InvariantCulture));

            if (n == 500.0)
                Console.WriteLine("O número informado é igual a 500.");
            else if (n > 500.0)
                Console.WriteLine("O número informado é maior que 500.");
            else
                Console.WriteLine("O número informado é menor que 500.");

        }
    }
}