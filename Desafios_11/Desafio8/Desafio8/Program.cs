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
                char resposta = 's';
                while (resposta != 'n')
                {
                    Console.WriteLine("Esse programa calcula o salário líquido dado desconto ao salário bruto.");
                    Console.Write("Digite o salário bruto: R$ ");
                    double salarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
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
