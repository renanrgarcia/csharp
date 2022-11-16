using System;

// Crie um algoritmo que leia um número inteiro e informe se ele é ou não divisível por 7.

namespace Desafio5
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
                    Console.WriteLine("Esse programa informa se um número é divisível por outro.");

                    int numerador = 0;
                    bool sucesso = false;
                    do
                    {
                        Console.Write("Digite um número inteiro a ser dividido (numerador): ");
                        string n = Console.ReadLine();

                        Console.Clear();
                        sucesso = int.TryParse(n, out numerador);
                        if (!sucesso)
                        {
                            Console.WriteLine("Você deve digitar um valor inteiro."
                                + $"O valor digitado '{n ?? "<null>"}' não é compatível.");
                        }
                    } while (!sucesso);

                    int denominador = 0;
                    sucesso = false;
                    do
                    {
                        Console.Write("Digite um número inteiro não nulo que será o divisor (denominador): ");
                        string d = Console.ReadLine();

                        Console.Clear();
                        sucesso = int.TryParse(d, out denominador);
                        if (!sucesso || denominador == 0)
                        {
                            Console.WriteLine("Você deve digitar um valor inteiro diferente de zero."
                                + $"O valor digitado '{d ?? "<null>"}' não é compatível.");
                        }
                    } while (!sucesso || denominador == 0);

                    int resto = numerador % denominador;

                    if (numerador % denominador == 0)
                        Console.WriteLine($"O número {numerador} é divisível por {denominador}. Resto: {resto}");
                    else
                        Console.WriteLine($"O número {numerador} não é divisível por {denominador}. Resto: {resto}");

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