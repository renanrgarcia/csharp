using System;

namespace Desafio8
{
    internal class CalculadoraSalario
    {

        public static double SalarioLiquido(double salariobruto)
        {
            if (salariobruto < 2000)
                return salariobruto -= salariobruto * 0.25;
            else
                return salariobruto -= salariobruto * 0.35;
        }

    }
}
