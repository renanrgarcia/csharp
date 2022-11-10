using System;
using System.Globalization;

// Crie um algoritmo que leia uma senha fornecida pelo usuário composta por caracteres para informar se a senha é válida ou inválida.
// A senha do sistema corresponde a palavra “SENHA”. Obs.: O algoritmo não faz distinção de letras maiúsculas e minúsculas.

namespace Desafio2
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
                    Console.WriteLine("Esse sistema informa se a senha informada é válida ou não.");
                    Console.Write("Digite sua senha: ");
                    string senha = Console.ReadLine().ToUpper();

                    if (senha.Equals("SENHA"))
                        Console.WriteLine("Senha válida!"); 
                    else
                        Console.WriteLine("Senha inválida!");

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