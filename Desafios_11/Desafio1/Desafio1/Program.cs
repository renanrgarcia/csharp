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
                string resposta = "s";
                double constante = 100.0;
                while (resposta != "n")
                {
                    Console.WriteLine($"Esse programa responde se o número digitado é maior do que {constante}.");
                    Console.Write("Digite um número real: ");
                    string valor = Console.ReadLine();

                    bool successo = double.TryParse(valor, out double numero);
                    if (successo)
                    {
                        if (numero == constante)
                            Console.WriteLine($"O número informado é igual a {constante}.");
                        else if (numero > constante)
                            Console.WriteLine($"O número informado é maior que {constante}.");
                        else
                            Console.WriteLine($"O número informado é menor que {constante}.");
                    }
                    else
                    {
                        Console.WriteLine("Este programa exige a entrada de um número real. "
                            + $"O valor digitado '{valor ?? "<null>"}' não é compatível.");
                    }

                    Console.Write("Gostaria de executar o programa novamente (s/n)? ");
                    resposta = Console.ReadLine().ToLower();

                    while (resposta != "s" && resposta != "n")
                    {
                        Console.Clear();
                        Console.WriteLine($"Digite (s) para sim ou (n) para não. " +
                            $"O valor '{resposta ?? "<null>"}' não é compatível.");
                        Console.Write("Gostaria de executar o programa novamente (s/n)? ");
                        resposta = Console.ReadLine().ToLower();
                    }
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