using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificarNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("Digite um número: ");
            x = int.Parse(Console.ReadLine());
            Console.ReadKey();

            Console.WriteLine("Digite outro número: ");
            y = int.Parse(Console.ReadLine());

            if (x == y)
            {
                Console.WriteLine("Os números são iguais");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Os números são diferentes");
                Console.ReadKey();
            }
        }
    }
}
