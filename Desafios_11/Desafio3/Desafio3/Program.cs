using System;
using System.Globalization;

// Crie um algoritmo que leia um número e alerte quando o mesmo estiver entre -100 e 100.

namespace Desafio3
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
                    Console.WriteLine("Esse sistema alerta se o número informado está entre -100 e 100.");
                    Console.Write("Digite um número: ");
                    double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    ComparaNumero numero = new ComparaNumero(x);

                    if (numero.PertenceIntervalo(x) == true)
                    {
                        Console.WriteLine("O número é " + x.ToString(CultureInfo.InvariantCulture) + " e está entre -100 e 100.");
                    }
                    else
                    {
                        Console.WriteLine("O número é " + x.ToString(CultureInfo.InvariantCulture) + " e não está entre -100 e 100.");
                    }
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