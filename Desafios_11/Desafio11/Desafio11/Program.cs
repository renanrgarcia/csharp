using System;
using Desafio11;
using System.Globalization;

// Crie um algoritmo que leia três números e exibe os números em ordem crescente.

namespace Desafio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Esse programa exibe os três números digitados em ordem crescente.");
            Console.Write("Digite os três números entre espaços: ");
            string[] s = Console.ReadLine().Split(' ');
            double n1 = double.Parse(s[0], CultureInfo.InvariantCulture);
            double n2 = double.Parse(s[1], CultureInfo.InvariantCulture);
            double n3 = double.Parse(s[2], CultureInfo.InvariantCulture);

            ComparaNumeros comp = new ComparaNumeros(n1, n2, n3);

            // 3 números iguais
            if (n1 == n2 && n2 == n3)
                Console.WriteLine("Os três números são iguais! Seguem os números: "
                    + n1.ToString("F2", CultureInfo.InvariantCulture) + ", "
                    + n2.ToString("F2", CultureInfo.InvariantCulture) + ", "
                    + n3.ToString("F2", CultureInfo.InvariantCulture) + ".");

            // 2 números iguais
            else if (n1 == n2 || n2 == n3 || n1 == n3)
            {
                double maiorDoisIguais = comp.MaiorDoisIguais(n1, n2, n3);
                double menorDoisIguais = comp.MenorDoisIguais(n1, n2, n3);
                Console.WriteLine("Há dois números iguais! Segue a ordem crescente: ");

                double[] num = new double[3];
                num[0] = n1;
                num[1] = n2;
                num[2] = n3;

                // Dois iguais maiores
                if (maiorDoisIguais == n1 && n1 == n2)
                    Console.Write("{0}, {1}, {2}.", n3.ToString(CultureInfo.InvariantCulture),
                        n1.ToString(CultureInfo.InvariantCulture),
                        n2.ToString(CultureInfo.InvariantCulture));
                else if (maiorDoisIguais == n2 && n2 == n3)
                    Console.Write("{0}, {1}, {2}.", n1.ToString(CultureInfo.InvariantCulture),
                        n2.ToString(CultureInfo.InvariantCulture),
                        n3.ToString(CultureInfo.InvariantCulture));
                else if (maiorDoisIguais == n3 && n3 == n1)
                    Console.Write("{0}, {1}, {2}.", n2.ToString(CultureInfo.InvariantCulture),
                        n3.ToString(CultureInfo.InvariantCulture),
                        n1.ToString(CultureInfo.InvariantCulture));
                // Dois iguais menores
                else if (menorDoisIguais == n1 && n1 == n2)
                    Console.Write("{0}, {1}, {2}.", n1.ToString(CultureInfo.InvariantCulture),
                        n2.ToString(CultureInfo.InvariantCulture),
                        n3.ToString(CultureInfo.InvariantCulture));
                else if (menorDoisIguais == n2 && n2 == n3)
                    Console.Write("{0}, {1}, {2}.", n2.ToString(CultureInfo.InvariantCulture),
                        n3.ToString(CultureInfo.InvariantCulture),
                        n1.ToString(CultureInfo.InvariantCulture));
                else
                    Console.Write("{0}, {1}, {2}.", n3.ToString(CultureInfo.InvariantCulture),
                        n1.ToString(CultureInfo.InvariantCulture),
                        n2.ToString(CultureInfo.InvariantCulture));
            }

            // 3 números diferentes
            else // if (n1 != n2 && n2 != n3)
            {
                double maior = comp.MaiorNumero(n1, n2, n3);
                double menor = comp.MenorNumero(n1, n2, n3);
                double central = comp.NumeroCentral(n1, n2, n3);
                Console.WriteLine("Os números em ordem crescente são "
                    + menor.ToString("F2", CultureInfo.InvariantCulture) + ", "
                    + central.ToString("F2", CultureInfo.InvariantCulture) + ", "
                    + maior.ToString("F2", CultureInfo.InvariantCulture) + ".");

            }



        }
    }
}