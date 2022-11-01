using System;
using System.Globalization;

// Crie um algoritmo que leia dois valores diferentes e determine o maior.


namespace Desafio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Esse programa determina o maior entre dois valores diferentes.");
            Console.Write("Informe os dois valores com espaço entre eles: ");
            string[] s = Console.ReadLine().Split(' ');
            double numero1 = double.Parse(s[0], CultureInfo.InvariantCulture);
            double numero2 = double.Parse(s[1], CultureInfo.InvariantCulture);

            if (numero1 == numero2)
                Console.WriteLine($"Os números {numero1.ToString(CultureInfo.InvariantCulture)} e {numero2.ToString(CultureInfo.InvariantCulture)} são iguais.");
            else if (numero1 > numero2)
                Console.WriteLine($"O número {numero1.ToString(CultureInfo.InvariantCulture)} é maior que {numero2.ToString(CultureInfo.InvariantCulture)}.");
            else 
                Console.WriteLine($"O número {numero2.ToString(CultureInfo.InvariantCulture)} é maior que {numero1.ToString(CultureInfo.InvariantCulture)}.");

        }
    }
}