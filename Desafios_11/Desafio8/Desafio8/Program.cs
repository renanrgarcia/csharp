using System;
using System.Globalization;

// Crie um algoritmo que após receber o Salário Bruto, calcule o salário líquido descontando 25% quando
// o salário bruto for menor que R$ 2000, caso contrário descontar 35%. No final, exiba o salário líquido.

namespace Desafio8
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
                    Console.WriteLine("Esse programa calcula o salário líquido dado desconto ao salário bruto.");

                    double salarioBruto = 0.0;
                    do
                    {
                        Console.Write("Digite o salário bruto: R$ ");
                        string sb = Console.ReadLine();

                        Console.Clear();
                        bool successo = double.TryParse(sb, NumberStyles.Number, CultureInfo.InvariantCulture, out salarioBruto);
                        if (!successo || salarioBruto <= 0.0)
                        {
                            Console.WriteLine("Você deve digitar um valor real positivo não nulo. "
                                + $"O valor digitado '{sb ?? "<null>"}' não é compatível.");
                        }
                    } while (salarioBruto <= 0.0);

                    double salarioLiquido = 0.0;
                    double desconto = 0.0;
                    if (salarioBruto < 2000.0)
                    {
                        desconto = 0.25;
                        salarioLiquido = salarioBruto - salarioBruto * desconto;
                    }
                    else
                    {
                        desconto = 0.35;
                        salarioLiquido = salarioBruto - salarioBruto * desconto;
                    }

                    Console.WriteLine("O salário líquido é R$ " + salarioLiquido.ToString("F2", CultureInfo.InvariantCulture)
                        + ". Desconto: " + desconto + "%.");

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
