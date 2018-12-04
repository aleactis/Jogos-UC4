using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            int nota;
            string nome;
            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.Write("Digite a nota do aluno: ");
            nota = int.Parse(Console.ReadLine());

            if (nota >= 7)
            {
                Console.WriteLine("Aluno Aprovado");

            }
            else if (nota >= 5)
            {
                Console.WriteLine("Aluno em Recuperação");
            }
            else
            {
                Console.WriteLine("Aluno Reprovado");
            }
        }
    }
}
