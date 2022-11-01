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
            Console.WriteLine("Esse programa retorna o valor de venda de um produto e o lucro obtido.");
            Console.Write("Digite o valor de compra do produto: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Produto product = new Produto(preco);

            Console.WriteLine(product);
        }
    }
}


