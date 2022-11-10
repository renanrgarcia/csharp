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
                string resposta = "s";
                double intervaloInferior = -100.0;
                double intervaloSuperior = 100.0;

                while (resposta != "n")
                {
                    Console.WriteLine($"Esse sistema alerta se o número informado está entre {intervaloInferior} e {intervaloSuperior}.");
                    Console.Write("Digite um número: ");
                    double numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    if (numero >= intervaloInferior && numero <= intervaloSuperior)
                        Console.WriteLine("O número é " + numero.ToString(CultureInfo.InvariantCulture) + $" e está entre {intervaloInferior} e {intervaloSuperior}.");
                    else
                        Console.WriteLine("O número é " + numero.ToString(CultureInfo.InvariantCulture) + $" e não está entre {intervaloInferior} e {intervaloSuperior}.");

                    Console.Write("Gostaria de executar o programa novamente (s/n)? ");
                    resposta = Console.ReadLine().ToLower();
                    while (resposta.Length > 1)
                    {
                        Console.Clear();
                        Console.WriteLine("Você digitou mais de um caracter. Digite (s) para sim ou (n) para não.");
                        Console.Write("Gostaria de executar o programa novamente (s/n)? ");
                        resposta = Console.ReadLine().ToLower();
                    }
                    Console.Clear();

                    intervaloInferior -= 5;
                    intervaloSuperior += 5;

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