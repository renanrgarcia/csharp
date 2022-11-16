using System;
using System.Globalization;

// Crie um algoritmo que leia a média das duas unidades (matérias) para calcular a sua média final.
// Em seguida, exiba a média final e o resultado que pode ser aprovado, prova final ou reprovado.
// A média de aprovação é 7, menor que 3 para reprovação e as demais prova final.

namespace Desafio10
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
                    Console.WriteLine("Esse programa calcula a média final e o status de aprovação de duas matérias para um aluno.");

                    double[,] mat = new double[2, 4];

                    
                    for (int i = 0; i < 2; i++)
                    {
                        bool sucesso = false;
                        Console.WriteLine($"Digite as quatro notas da {i + 1}ª matéria abaixo. ");
                        for (int j = 0; j < 4; j++)
                            do
                            {
                                Console.Write($"Digite a {j + 1}ª nota: ");
                                string nota = Console.ReadLine();
                                sucesso = double.TryParse(nota, NumberStyles.Number, CultureInfo.InvariantCulture, out mat[i, j]);
                                if (!sucesso || mat[i, j] <= 0.0)
                                {
                                    Console.WriteLine("Você deve digitar um valor real positivo"
                                        + $"O valor digitado '{nota ?? "<null>"}' não é compatível.");
                                }
                            } while (!sucesso || mat[i, j] <= 0.0);
                        Console.Clear();
                    }

                    double[] media = new double[2];
                    double sum = 0.0;

                    for (int i = 0; i < 2; i++)
                    {
                        for (int j = 0; j < 4; j++)
                        {
                            sum += mat[i, j];
                        }
                        media[i] = sum / 4;
                        sum = 0.0;
                    }

                    double MediaFinal = (media[0] + media[1]) / 2.0;

                    if (MediaFinal >= 7.0)
                        Console.WriteLine("Média final = " + MediaFinal.ToString("F1", CultureInfo.InvariantCulture) + ". O aluno está Aprovado.");
                    else if (MediaFinal >= 3.0)
                        Console.WriteLine("Média final = " + MediaFinal.ToString("F1", CultureInfo.InvariantCulture) + ". O aluno fará Prova Final.");
                    else
                        Console.WriteLine("Média final = " + MediaFinal.ToString("F1", CultureInfo.InvariantCulture) + ". O aluno está Reprovado.");

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