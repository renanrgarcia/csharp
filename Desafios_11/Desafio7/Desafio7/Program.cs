using System;
using System.Globalization;

// Crie um algoritmo que leia dois valores diferentes e determine o maior.

namespace Desafio7
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
                    Console.WriteLine("Esse programa determina o maior entre dois valores diferentes.");

                    double numero1 = 0.0;
                    bool sucesso = false;
                    do
                    {
                        Console.Write("Informe o primeiro valor real: ");
                        string n1 = Console.ReadLine();

                        Console.Clear();
                        sucesso = double.TryParse(n1, NumberStyles.Number, CultureInfo.InvariantCulture, out numero1);
                        if (!sucesso)
                        {
                            Console.WriteLine("Você deve digitar um valor real. "
                                + $"O valor digitado '{n1 ?? "<null>"}' não é compatível.");
                        }
                    } while (!sucesso);

                    double numero2 = 0.0;
                    sucesso = false;
                    do
                    {
                        Console.Write("Informe o segundo valor real: ");
                        string n2 = Console.ReadLine();

                        Console.Clear();
                        sucesso = double.TryParse(n2, NumberStyles.Number, CultureInfo.InvariantCulture, out numero2);
                        if (!sucesso)
                        {
                            Console.WriteLine("Você deve digitar um valor real. "
                                + $"O valor digitado '{n2 ?? "<null>"}' não é compatível.");
                        }
                    } while (!sucesso);

                    if (numero1 == numero2)
                        Console.WriteLine($"Os números {numero1.ToString(CultureInfo.InvariantCulture)} e {numero2.ToString(CultureInfo.InvariantCulture)} são iguais.");
                    else if (numero1 > numero2)
                        Console.WriteLine($"O número {numero1.ToString(CultureInfo.InvariantCulture)} é maior que {numero2.ToString(CultureInfo.InvariantCulture)}.");
                    else
                        Console.WriteLine($"O número {numero2.ToString(CultureInfo.InvariantCulture)} é maior que {numero1.ToString(CultureInfo.InvariantCulture)}.");

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