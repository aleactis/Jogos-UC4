using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Digite um número: ");
            num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("O número digitado é par");
            }
            else
            {
                Console.WriteLine("O número digitado é ímpar");
            }
        }
    }
}
