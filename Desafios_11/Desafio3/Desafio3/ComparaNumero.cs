using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio3
{
    internal class ComparaNumero
    {
        public double Numero { get; set; }

        public ComparaNumero (double numero)
        {
            Numero = numero;
        }

        public bool PertenceIntervalo(double numero)
        {
            if (numero >= -100.0 && numero <= 100.0)
                return true;
            else
                return false;
        }
    }
}
