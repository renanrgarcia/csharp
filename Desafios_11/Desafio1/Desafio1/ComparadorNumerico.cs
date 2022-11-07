namespace Desafio1
{
    internal class ComparadorNumerico
    {
        public double Numero { get; set; }

        public ComparadorNumerico (double numero)
        {
            Numero = numero;
        }

        public string ComparaNumero(double numero)
        {
            if (numero == 500.0)
                return "O número informado é igual a 500.";
            else if (numero > 500.0)
                return "O número informado é maior que 500.";
            else
                return "O número informado é menor que 500.";
        }
    }
}
