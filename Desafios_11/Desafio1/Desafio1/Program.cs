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
                Console.WriteLine("Esse programa responde se o número digitado é maior do que 500.");
                Console.Write("Digite um número: ");
                double numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                ComparadorNumerico comp = new ComparadorNumerico(numero);
                Console.WriteLine(comp.ComparaNumero(numero));
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}