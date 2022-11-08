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
                char resposta = 's';
                while (resposta != 'n')
                {
                    Console.WriteLine("Esse programa calcula a média final e o status de aprovação de duas matérias para um aluno.");

                    double[,] mat = new double[2, 4];

                    for (int i = 0; i < 2; i++)
                    {
                        Console.Write($"Digite as quatro notas da {i + 1} matéria entre espaços: ");
                        string[] valores = Console.ReadLine().Split(' ');
                        for (int j = 0; j < 4; j++)
                            mat[i, j] = double.Parse(valores[j], CultureInfo.InvariantCulture);
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
                        sum = 0;
                    }

                    double MediaFinal = (media[0] + media[1]) / 2;

                    if (MediaFinal >= 7.0)
                        Console.WriteLine("Média final = " + MediaFinal.ToString("F1", CultureInfo.InvariantCulture) + ". O aluno está Aprovado.");
                    else if (MediaFinal >= 3.0)
                        Console.WriteLine("Média final = " + MediaFinal.ToString("F1", CultureInfo.InvariantCulture) + ". O aluno fará Prova Final.");
                    else
                        Console.WriteLine("Média final = " + MediaFinal.ToString("F1", CultureInfo.InvariantCulture) + ". O aluno está Reprovado.");

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