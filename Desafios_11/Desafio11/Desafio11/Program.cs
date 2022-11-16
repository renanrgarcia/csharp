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
            try
            {
                string resposta = "s";
                while (resposta != "n")
                {
                    Console.WriteLine("Esse programa exibe os três números digitados em ordem crescente.");

                    double n1, n2, n3;
                    bool sucesso = false;
                    do
                    {
                        Console.Write($"Digite o primeiro número: ");
                        string num = Console.ReadLine();
                        sucesso = double.TryParse(num, NumberStyles.Number, CultureInfo.InvariantCulture, out n1);
                        if (!sucesso)
                        {
                            Console.WriteLine("Você deve digitar um valor real"
                                + $"O valor digitado '{num ?? "<null>"}' não é compatível.");
                        }
                    } while (!sucesso);

                    do
                    {
                        Console.Write($"Digite o primeiro número: ");
                        string num = Console.ReadLine();
                        sucesso = double.TryParse(num, NumberStyles.Number, CultureInfo.InvariantCulture, out n2);
                        if (!sucesso)
                        {
                            Console.WriteLine("Você deve digitar um valor real"
                                + $"O valor digitado '{num ?? "<null>"}' não é compatível.");
                        }
                    } while (!sucesso);

                    do
                    {
                        Console.Write($"Digite o primeiro número: ");
                        string num = Console.ReadLine();
                        sucesso = double.TryParse(num, NumberStyles.Number, CultureInfo.InvariantCulture, out n3);
                        if (!sucesso)
                        {
                            Console.WriteLine("Você deve digitar um valor real"
                                + $"O valor digitado '{num ?? "<null>"}' não é compatível.");
                        }
                    } while (!sucesso);

                    // 3 números iguais
                    if (n1 == n2 && n2 == n3)
                        Console.WriteLine("Os três números são iguais! Seguem os números: "
                            + n1.ToString(CultureInfo.InvariantCulture) + ", "
                            + n2.ToString(CultureInfo.InvariantCulture) + ", "
                            + n3.ToString(CultureInfo.InvariantCulture) + ".");

                    // 2 números iguais
                    else if (n1 == n2 || n2 == n3 || n1 == n3)
                    {
                        double maiorDoisIguais = MaiorDoisIguais(n1, n2, n3);
                        double menorDoisIguais = MenorDoisIguais(n1, n2, n3);
                        Console.Write("Há dois números iguais! Segue a ordem crescente: ");

                        double[] num = new double[3];
                        num[0] = n1;
                        num[1] = n2;
                        num[2] = n3;

                        // Dois iguais maiores
                        if (maiorDoisIguais == n1 && n1 == n2)
                            Console.WriteLine("{0}, {1}, {2}.", n3.ToString(CultureInfo.InvariantCulture),
                                n1.ToString(CultureInfo.InvariantCulture),
                                n2.ToString(CultureInfo.InvariantCulture));
                        else if (maiorDoisIguais == n2 && n2 == n3)
                            Console.WriteLine("{0}, {1}, {2}.", n1.ToString(CultureInfo.InvariantCulture),
                                n2.ToString(CultureInfo.InvariantCulture),
                                n3.ToString(CultureInfo.InvariantCulture));
                        else if (maiorDoisIguais == n3 && n3 == n1)
                            Console.WriteLine("{0}, {1}, {2}.", n2.ToString(CultureInfo.InvariantCulture),
                                n3.ToString(CultureInfo.InvariantCulture),
                                n1.ToString(CultureInfo.InvariantCulture));
                        // Dois iguais menores
                        else if (menorDoisIguais == n1 && n1 == n2)
                            Console.WriteLine("{0}, {1}, {2}.", n1.ToString(CultureInfo.InvariantCulture),
                                n2.ToString(CultureInfo.InvariantCulture),
                                n3.ToString(CultureInfo.InvariantCulture));
                        else if (menorDoisIguais == n2 && n2 == n3)
                            Console.WriteLine("{0}, {1}, {2}.", n2.ToString(CultureInfo.InvariantCulture),
                                n3.ToString(CultureInfo.InvariantCulture),
                                n1.ToString(CultureInfo.InvariantCulture));
                        else
                            Console.WriteLine("{0}, {1}, {2}.", n3.ToString(CultureInfo.InvariantCulture),
                                n1.ToString(CultureInfo.InvariantCulture),
                                n2.ToString(CultureInfo.InvariantCulture));
                    }

                    // 3 números diferentes
                    else // if (n1 != n2 && n2 != n3)
                    {
                        double maior = MaiorNumero(n1, n2, n3);
                        double menor = MenorNumero(n1, n2, n3);
                        double central = NumeroCentral(n1, n2, n3);
                        Console.WriteLine("Os números em ordem crescente são "
                            + menor.ToString(CultureInfo.InvariantCulture) + ", "
                            + central.ToString(CultureInfo.InvariantCulture) + ", "
                            + maior.ToString(CultureInfo.InvariantCulture) + ".");
                    }

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

        public static double MaiorNumero(double n1, double n2, double n3)
        {
            return Math.Max(n1, Math.Max(n2, n3));
        }

        public static double MenorNumero(double n1, double n2, double n3)
        {
            return Math.Min(n1, Math.Min(n2, n3));
        }

        public static double NumeroCentral(double n1, double n2, double n3)
        {
            if (MaiorNumero(n1, n2, n3) == n1)
                if (MenorNumero(n1, n2, n3) == n2)
                    return n3;
                else
                    return n2;
            if (MaiorNumero(n1, n2, n3) == n2)
                if (MenorNumero(n1, n2, n3) == n1)
                    return n3;
                else
                    return n1;
            else
                if (MenorNumero(n1, n2, n3) == n1)
                return n2;
            else
                return n1;
        }

        public static double MaiorDoisIguais(double n1, double n2, double n3)
        {
            if (n1 == n2)
                return Math.Max(n2, n3);
            else if (n2 == n3)
                return Math.Max(n3, n1);
            else
                return Math.Max(n1, n2);
        }

        public static double MenorDoisIguais(double n1, double n2, double n3)
        {
            if (n1 == n2)
                return Math.Min(n2, n3);
            else if (n2 == n3)
                return Math.Min(n3, n1);
            else
                return Math.Min(n1, n2);
        }
    }
}