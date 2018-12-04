using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaMediaReal
{
    class Program
    {
        static void Main(string[] args)
        {
            float media, n1, n2, n3;
            string nome;

            Console.Write("Digite o nome do aluno: ");
            nome = Console.ReadLine();

            Console.Write("Digite a primeira nota: ");
            n1 = int.Parse(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            n2 = int.Parse(Console.ReadLine());

            Console.Write("Digite a terceira nota: ");
            n3 = int.Parse(Console.ReadLine());

            media = (n1 + n2 + n3) / 3;
            Console.WriteLine("A média do aluno foi: " + media);
           
            if (media >= 7)
            {
                Console.WriteLine("Aprovado");
            }
            else if (media < 5)
            {
                Console.WriteLine("Reprovado");
            }
            else
            {
                Console.WriteLine("Recuperação");
            }
        }
    }
}
