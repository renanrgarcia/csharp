using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio11
{
    internal class ComparaNumeros
    {
        public double N1 { get; set; }
        public double N2 { get; set; }
        public double N3 { get; set; }

        public ComparaNumeros()
        {
        }

        public ComparaNumeros(double n1, double n2, double n3)
        {
            N1 = n1;
            N2 = n2;
            N3 = n3;
        }

        public double MaiorNumero(double n1, double n2, double n3)
        {
            return Math.Max(n1, Math.Max(n2, n3));
        }

        public double MenorNumero(double n1, double n2, double n3)
        {
            return Math.Min(n1, Math.Min(n2, n3));
        }

        public double NumeroCentral(double n1, double n2, double n3)
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

        public double MaiorDoisIguais(double n1, double n2, double n3)
        {
            if (n1 == n2)
                return Math.Max(n2, n3);
            else if (n2 == n3)
                return Math.Max(n3, n1);
            else
                return Math.Max(n1, n2);
        }

        public double MenorDoisIguais(double n1, double n2, double n3)
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
