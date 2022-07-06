using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1_Djalma_2_semestre
{
	internal class Program
	{
		static void Main(string[] args)
		{
            double Nota1, Nota2, Nota3, Media;
            string nome;

            Console.WriteLine("Digite o seu nome:");
            nome = Console.ReadLine();

            Console.WriteLine("Digite a sua nota de participação");
            Nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a sua nota da prova mensal");
            Nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a sua nota de seminário");
            Nota3 = double.Parse(Console.ReadLine());

            Media = ((Nota1 + Nota2 + Nota3) / 3);

            if (Media > 8.5)
            {
                Console.WriteLine(" Media Final: Excelente!!");
            }
            if (Media >= 7.0 == Media <= 8.4)
            {
                Console.WriteLine(" Media Final: Aprovado");
            }
            if (Media >= 6.0 == Media <= 6.9)
            {
                Console.WriteLine(" Media Final: Mediano");
            }
            if (Media >= 0.1 == Media <= 5.9)
            {
                Console.WriteLine(" Media Final: Abaixo da Média");
            }
            if (Media == 0.0)
            {
                Console.WriteLine(" Media Final: Reprovado!!");
            }
            Console.ReadKey();
        }
	}
}
