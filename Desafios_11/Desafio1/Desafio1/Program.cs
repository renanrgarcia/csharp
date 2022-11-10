using System;
using System.Globalization;

// Crie um algoritmo que leia um número e alerte quando o mesmo for maior do que 500.

namespace Desafio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                char resposta = 's';
                double constante = 100.0;
                while (resposta != 'n')
                {
                    Console.WriteLine($"Esse programa responde se o número digitado é maior do que {constante}.");
                    Console.Write("Digite um número: ");
                    double numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    if (numero == constante)
                        Console.WriteLine($"O número informado é igual a {constante}.");
                    else if (numero > constante)
                        Console.WriteLine($"O número informado é maior que {constante}.");
                    else 
                        Console.WriteLine($"O número informado é menor que {constante}.");

                    Console.Write("Gostaria de executar o programa novamente (s/n)? ");
                    resposta = char.Parse(Console.ReadLine().ToLower());
                    Console.Clear();

                    constante *= 2;
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