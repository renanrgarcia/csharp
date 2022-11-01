using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Desafio10
{
    internal class Materia
    {
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double Nota3 { get; set; }
        public double Nota4 { get; set; }

        public Materia()
        {
        }

        public Materia(double nota1, double nota2, double nota3, double nota4)
        {
            Nota1 = nota1;
            Nota2 = nota2;
            Nota3 = nota3;
            Nota4 = nota4;
        }

        public double MediaMateria(double nota1, double nota2, double nota3, double nota4)
        {
            return (nota1 + nota2 + nota3 + nota4)/4;
        }

        

        override 
    }
}
