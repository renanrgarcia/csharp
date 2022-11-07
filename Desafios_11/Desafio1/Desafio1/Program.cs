using System;
using System.Globalization;

// Crie um algoritmo que leia um número e alerte quando o mesmo for maior do que 500.

namespace Desafio1
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
                    Console.WriteLine("Esse programa responde se o número digitado é maior do que 500.");
                    Console.Write("Digite um número: ");
                    double numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    ComparadorNumerico comp = new ComparadorNumerico(numero);
                    Console.WriteLine(comp.ComparaNumero(numero));

                    Console.Write("Gostaria de eecutar o programa novamente (s/n)? ");
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