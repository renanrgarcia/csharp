using System;
using System.Net.Mail;

// Crie um algoritmo que leia uma senha fornecida pelo usuário composta por caracteres para informar se a senha é válida ou inválida.
// A senha do sistema corresponde a palavra “SENHA”. Obs.: O algoritmo não faz distinção de letras maiúsculas e minúsculas.

namespace Desafio2 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Esse sistema informa se a senha informada é válida ou não.");
            Console.Write("Digite sua senha: ");
            string senha = Console.ReadLine();
            Login log = new Login(senha);

            if (log.TesteSenha(senha) == true)
            {
                Console.WriteLine("Senha válida!");
            }
            else
            {
                Console.WriteLine("Senha inválida!");
            }
            

        }
    }
}