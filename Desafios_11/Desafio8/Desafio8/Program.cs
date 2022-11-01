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
            Console.WriteLine("Esse programa calcula o salário líquido dado desconto ao salário bruto.");
            Console.Write("Digite o salário bruto: R$ ");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double salarioliquido = CalculadoraSalario.SalarioLiquido(salario);

            Console.WriteLine("O salário líquido é R$ " + salarioliquido.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
