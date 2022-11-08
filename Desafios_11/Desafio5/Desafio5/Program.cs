using System;

// Crie um algoritmo que leia um número inteiro e informe se ele é ou não divisível por 7.

namespace MyApp // Note: actual namespace depends on the project name.
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
                    Console.WriteLine("Esse programa informa se o número digitado é divisível por 7.");
                    Console.Write("Digite um número inteiro: ");
                    int numero = int.Parse(Console.ReadLine());

                    if (numero % 7 == 0)
                        Console.WriteLine("O número " + numero + " é divisível por 7. Resto: 0");
                    else
                        Console.WriteLine("O número " + numero + " não é divisível por 7. Resto: " + numero % 7);

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