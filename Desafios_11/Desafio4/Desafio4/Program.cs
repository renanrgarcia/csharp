using System;
using System.Globalization;


// Crie um algoritmo que leia três notas para calcular a média do aluno e determinar se o mesmo foi aprovado ou reprovado.
// A média para aprovação é 6,5.

namespace Desafio4
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
                    Console.WriteLine("Esse programa lê as notas de um aluno, calcula sua média e determina se foi ou não aprovado.");

                    int n = 0;
                    do
                    {
                        Console.Write("Quantas notas deseja inserir? ");
                        string x = Console.ReadLine();

                        Console.Clear();
                        bool successo = int.TryParse(x, out n);
                        if (!successo || n <= 0)
                        {
                            Console.WriteLine("Você deve digitar um valor inteiro positivo não nulo. "
                                + $"O valor digitado '{x ?? "<null>"}' não é compatível.");
                        }
                    } while (n < 1);

                    double mediaAprovacao = 0;
                    do
                    {
                        Console.Write("Qual o valor da média para aprovação? ");
                        string m = Console.ReadLine();

                        Console.Clear();
                        bool successo = double.TryParse(m, out mediaAprovacao);
                        if (!successo || mediaAprovacao <= 0.0)
                        {
                            Console.WriteLine("Você deve digitar um valor real positivo não nulo. "
                                + $"O valor digitado '{m ?? "<null>"}' não é compatível.");
                        }
                    } while (mediaAprovacao <= 0.0);

                    double[] vetor = new double[n];
                    for (int i = 0; i < n; i++)
                    {
                        bool sucesso = false;
                        do
                        {
                            Console.Write($"Digite a {i + 1}ª nota: ");
                            string nota = Console.ReadLine();

                            Console.Clear();
                            sucesso = double.TryParse(nota, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out vetor[i]);
                            if (!sucesso || vetor[i] <= 0.0)
                            {
                                Console.WriteLine("Você deve digitar um valor real positivo não nulo. "
                                    + $"O valor digitado '{nota ?? "<null>"}' não é compatível.");
                            }
                        } while (vetor[i] < 0.0 || !sucesso);
                    }
                    Console.Clear();

                    double soma = 0;
                    for (int i = 0; i < n; i++)
                    {
                        soma += vetor[i];
                    }
                    double media = (double)soma / n;

                    string statusAprovacao;
                    if (media >= mediaAprovacao)
                        statusAprovacao = "aprovado";
                    else
                        statusAprovacao = "reprovado";

                    Console.WriteLine("A média do aluno é " + media.ToString("F1", CultureInfo.InvariantCulture) + ". Aluno " + statusAprovacao + "!");

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