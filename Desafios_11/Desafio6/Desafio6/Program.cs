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
                string resposta = "s";
                while (resposta != "n")
                {
                    Console.WriteLine("Esse programa informa se o número digitado é par ou ímpar.");
                    Console.Write("Digite um número inteiro: ");
                    string valor = Console.ReadLine();
                    int numero;

                    bool successo = int.TryParse(valor, out numero);
                    if (successo)
                    {
                        if (numero % 2 == 0)
                            Console.WriteLine($"O número {numero} é par.");
                        else
                            Console.WriteLine($"O número {numero} é ímpar.");
                    }
                    else
                    {
                        Console.WriteLine("Este programa exige a entrada de um valor inteiro. "
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

