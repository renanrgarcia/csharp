using System;

// Crie um algoritmo que leia um número inteiro e informe se ele é ou não divisível por 7.

namespace Desafio5
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
                    Console.WriteLine("Esse programa informa se um número é divisível por outro.");
                    Console.Write("Digite um número inteiro a ser dividido (numerador): ");
                    int numerador = int.Parse(Console.ReadLine());
                    

                    Console.Write("Digite um número inteiro que será o divisor (denominador): ");
                    int denominador = int.Parse(Console.ReadLine());

                    int resto = numerador % denominador;

                    if (numerador % denominador == 0)
                        Console.WriteLine($"O número {numerador} é divisível por {denominador}. Resto: {resto}");
                    else
                        Console.WriteLine($"O número {numerador} não é divisível por {denominador}. Resto: {resto}");

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