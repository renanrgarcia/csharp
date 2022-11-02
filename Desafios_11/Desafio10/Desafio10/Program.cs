using Desafio10.Enums;
using System;
using System.Globalization;

// Crie um algoritmo que leia a média das duas unidades (matérias) para calcular a sua média final.
// Em seguida, exiba a média final e o resultado que pode ser aprovado, prova final ou reprovado.
// A média de aprovação é 7, menor que 3 para reprovação e as demais prova final.

namespace Desafio10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Esse programa calcula a média final e o status de aprovação de duas matérias para um aluno.");

            double[,] mat = new double[2, 4];

            for (int i = 0; i < 2; i++)
            {
                Console.Write($"Digite as quatro notas da {i + 1} matéria entre espaços: ");
                string[] valores = Console.ReadLine().Split(' ');
                for (int j = 0; j < 4; j++)
                    mat[i, j] = double.Parse(valores[j], CultureInfo.InvariantCulture);
            }

            Materia M1 = new Materia(mat[0, 0], mat[0, 1], mat[0, 2], mat[0, 3]);
            Materia M2 = new Materia(mat[1, 0], mat[1, 1], mat[1, 2], mat[1, 3]);

            double Media1 = M1.MediaMateria(mat[0, 0], mat[0, 1], mat[0, 2], mat[0, 3]);
            double Media2 = M2.MediaMateria(mat[1, 0], mat[1, 1], mat[1, 2], mat[1, 3]);

            double MediaFinal = (Media1 + Media2) / 2;

            if (MediaFinal >= 7.0)
                Console.WriteLine("Média final = " + MediaFinal.ToString("F2", CultureInfo.InvariantCulture) + ". O aluno está " + StatusAprocao.Aprovado + ".");
            else if (MediaFinal >= 3.0)
                Console.WriteLine("Média final = " + MediaFinal.ToString("F2", CultureInfo.InvariantCulture) + ". O aluno fará " + StatusAprocao.ProvaFinal + ".");
            else
                Console.WriteLine("Média final = " + MediaFinal.ToString("F2", CultureInfo.InvariantCulture) + ". O aluno está " + StatusAprocao.Reprovado + ".");
        }
    }
}