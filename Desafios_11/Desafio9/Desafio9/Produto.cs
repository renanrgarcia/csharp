using System;
using System.Globalization;

namespace Desafio9
{
    internal class Produto
    {
        public double PrecoCompra { get; set; }

        public Produto(double precoCompra)
        {
            PrecoCompra = precoCompra;
        }

        public static double Precificacao(double precoCompra)
        {
            if (precoCompra >= 200)
                return precoCompra += precoCompra * 0.315;
            else
                return precoCompra -= precoCompra * 0.5;
        }

        public override string ToString()
        {
            return "O preço de compra é R$ " + PrecoCompra.ToString("F2", CultureInfo.InvariantCulture) + ". O preço de venda é de R$ " 
                + Precificacao(PrecoCompra).ToString("F2", CultureInfo.InvariantCulture) + ".";
        }
    }
}
