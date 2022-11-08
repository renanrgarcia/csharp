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
                char resposta = 's';
                while (resposta != 'n')
                {
                    Console.WriteLine("Esse programa lê três notas, calcula sua média e determina se foi ou não aprovado.");
                    Console.Write("Quantas notas deseja inserir? ");
                    int n = int.Parse(Console.ReadLine());
                    Console.Clear();

                    double[] vetor = new double[n];
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write($"Digite a {i + 1}ª nota: ");
                        vetor[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    }
                    Console.Clear();

                    double soma = 0;
                    for (int i = 0; i < n; i++)
                    {
                        soma += vetor[i];
                    }
                    double media = (double)soma / n;

                    string aprovacao;
                    if (media >= 6.5)
                        aprovacao = "aprovado";
                    else
                        aprovacao = "reprovado";

                    Console.WriteLine("A média do aluno é " + media.ToString("F1", CultureInfo.InvariantCulture) + ". Aluno " + aprovacao + "!");

                    Console.Write("Gostaria de executar o programa novamente (s/n)? ");
                    resposta = char.Parse(Console.ReadLine());
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