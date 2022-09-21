using System;

namespace Ex5Sec4
{
    class Program
    {
        static void Main(String[] args)
        {

            Grade studant = new Grade();

            Console.WriteLine("Digite as notas: ");
            studant.n1 = double.Parse(Console.ReadLine());
            studant.n2 = double.Parse(Console.ReadLine());
            studant.n3 = double.Parse(Console.ReadLine());
            if(studant.n1 > 30)
            {
                Console.WriteLine("Revise suas notas, algo esta errado");
            }else if(studant.n2 > 35)
            {
                Console.WriteLine("Revise suas notas, algo esta errado");
            }
            else if (studant.n3 > 35)
            {
                Console.WriteLine("Revise suas notas, algo esta errado");
            }
            else
            {
                Console.WriteLine("Nota final: " + studant.Media());
            }

            if(studant.Media() >= 60)
            {
                Console.WriteLine("Aluno Aprovado");
            }
            else
            {
                Console.WriteLine("Aluno reprovado, faltam: " + (60 - studant.Media()) + " pontos");
            }
        }
    }
}
