using System;
using System.Globalization;

// Um comerciante comprou um produto e quer vendê-lo com um lucro de 50% se o valor da compra for menor que R$ 200,
// caso contrário o lucro será de 31,5%. Crie um algoritmo que leia o valor da compra e exiba o valor da venda.

namespace Desafio9
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
                    Console.WriteLine("Esse programa retorna o valor de venda de um produto e o lucro obtido.");

                    double precoCompra = 0.0;
                    bool sucesso = false;
                    do
                    {
                        Console.Write("Digite o valor de compra do produto: ");
                        string pc = Console.ReadLine();

                        Console.Clear();
                        sucesso = double.TryParse(pc, NumberStyles.Number, CultureInfo.InvariantCulture, out precoCompra);
                        if (!sucesso || precoCompra <= 0.0)
                        {
                            Console.WriteLine("Você deve digitar um valor real positivo não nulo. "
                                + $"O valor digitado '{pc ?? "<null>"}' não é compatível.");
                        }
                    } while (!sucesso || precoCompra <= 0.0);
                                        
                    double precoVenda = 0.0;
                    double lucro = 0.0;

                    if (precoCompra >= 200)
                    {
                        lucro = 0.315;
                        precoVenda = precoCompra * (lucro + 1);
                    }
                    else
                    {
                        lucro = 0.5;
                        precoVenda = precoCompra * (lucro + 1);
                    }

                    double porcentagemLucro = lucro * 100;

                    Console.WriteLine("O preço de venda é R$ " + precoVenda.ToString("F2", CultureInfo.InvariantCulture)
                        + ". A porcentagem de lucro foi: " + porcentagemLucro.ToString("F1", CultureInfo.InvariantCulture) + "%.");

                    Console.Write("Gostaria de executar o programa novamente (s/n)? ");
                    resposta = Console.ReadLine().ToLower();

                    while (resposta != "s" && resposta != "n")
                    {
                        Console.Clear();
                        Console.WriteLine($"Digite (s) para sim ou (n) para não. " +
                            $"O valor '{resposta ?? "<null>"}' não é compatível.");
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


