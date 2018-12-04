using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDiversos
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 - Inverter números em uma sequência
            //InverteNumero();

            // 2 -Mostrar os números perfeitos dentro de um intervalo
            //NumerosPerfeitos();

            // 3 - Exibir número primo
            //Primos();

            // 4 - Verifica se o eleitor é brasileiro e possui mais de 16 anos
            //VerificaEleitor();

            // 5 - Exibir múltiplos de 3 até 100
            //MultiploTres();
            // 5 - Usando função recursiva
            //printMultiplos3(3);

            // 6 - Números divisiveis por 3 ou por 4 até 30
            //Divisivel3ou4();

            // 7 - Fatorial de  1 até 10
            //Fatorial();

            // 8 - Fibonacci até 100
            //Fibonacci();

            // 9 - For Encadeado
            //ForEncadeado();

            // 10 - Exibir uma forma de pirâmide com asteriscos baseado no nº de linhas informado pelo usúário
            //Piramide();

            // xx - Somar elementos de um Array
            SomarElementosArray();

        }

        private static void SomarElementosArray()
        {
            int n, soma = 0;

            Console.WriteLine("\n\nSomar todos os elementos de um array:\n");
            Console.WriteLine("----------------------------------------\n");

            Console.Write("Informe o número de elementos em seu array: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Digite {n} elementos em seu array: ");

            //Passa o número de elementos de um array para a função, e ela retorna a soma desses elementos
            soma = SomarElmenteos(n);

            Console.Write($"\n\nA soma dos elementos do array é: {soma} \n\n");
            Console.ReadKey();
        }

        private static int SomarElmenteos(int numElementos)
        {
            int[] arr = new int[100];
            int soma = 0;


            for (int i = 0; i < numElementos; i++)
            {
                Console.Write($"Elemento {i}: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < numElementos; i++)
            {
                soma += arr[1];
            }

            return soma;
        }

        static void Primos()
        {
            int num, i, ctr = 0;

            Console.Write("\n\n");
            Console.Write("Verifica se um número dado é primo:\n");
            Console.Write("-----------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Digite um número: ");
            num = Convert.ToInt32(Console.ReadLine());
            for (i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    ctr++;
                    break;
                }
            }
            if (ctr == 0 && num != 1)
                Console.Write("{0} é um número primo.\n", num);
            else
                Console.Write("{0} não é um número primo\n", num);
        }

        static void NumerosPerfeitos()
        {
            /*Um número se diz perfeito se é igual à soma de seus divisores próprios. Divisores próprios de um número positivo N são todos os divisores inteiros positivos de N exceto o próprio N.
            Por exemplo, o número 6, seus divisores próprios são 1, 2 e 3, cuja soma é igual à 6. 1 + 2 + 3 = 6
            Outro exemplo é o número 28, cujos divisores próprios são 1, 2, 4, 7 e 14, e a soma dos seus divisores próprios é 28.
            1 + 2 + 4 + 7 + 14 = 28*/
            int n, i, sum;
            int mn, mx;

            Console.Write("\n\n");
            Console.Write("Localiza números perfeitos em um intervalo dado:\n");
            Console.Write("------------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Digite um número do intervalo inicial : ");
            mn = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite um número do intervalo final : ");
            mx = Convert.ToInt32(Console.ReadLine());
            Console.Write("Os números perfeitos dentro do intervalo digitado são : ");
            for (n = mn; n <= mx; n++)
            {
                i = 1;
                sum = 0;
                while (i < n)
                {
                    if (n % i == 0)
                        sum = sum + i;
                    i++;
                }
                if (sum == n)
                    Console.Write("{0} ", n);
            }
            Console.Write("\n");
        }

        static void InverteNumero()
        {
            int num, r, sum = 0, t;

            Console.Write("\n\n");
            Console.Write("Exibir um sequência de números na ordem inversa:\n");
            Console.Write("--------------------------------------");
            Console.Write("\n\n");


            Console.Write("Digite uma sequência de números: ");
            num = Convert.ToInt32(Console.ReadLine());

            for (t = num; t != 0; t = t / 10)
            {
                r = t % 10;
                sum = sum * 10 + r;
            }
            Console.Write("Os números em seequência inversa são : {0} \n", sum);
        }

        static void Piramide()
        {
            int i, j, spc, rows, k;

            Console.Write("\n\n");
            Console.Write("Exibir um padrão como uma pirâmide com asteriscos:\n");
            Console.Write("-------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Informe o número de linhas : ");
            rows = Convert.ToInt32(Console.ReadLine());
            spc = rows + 4 - 1;
            for (i = 1; i <= rows; i++)
            {
                for (k = spc; k >= 1; k--)
                {
                    Console.Write(" ");
                }

                for (j = 1; j <= i; j++)
                    Console.Write("* ");
                Console.Write("\n");
                spc--;
            }
        }

        static void VerificaEleitor() {

            int idade = 16;
            bool brasileira = true;

            // se for brasileiro e tiver mais de 16 anos, pode votar
            if (idade >= 16 && brasileira)
                Console.WriteLine("Você pode votar");
            else // caso contrário não pode votar
                Console.WriteLine("Você não pode Votar");
        }

        static void MultiploTres()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine("Múltiplos de 3 até 100: " + i);
                }
            }

            //Segunda forma com apenas 2 linhas
            //for (int i = 3; i <= 100; i += 3)
            //    Console.WriteLine("Múltiplos de 3 até 100: " + i);

            //Terceira forma
            //for (int i = 3; i <= 100; i = i + 3)
            //    Console.WriteLine("Múltiplos de 3 até 100: " + i);
        }

        static void printMultiplos3(int number)
        {
            if (number < 100)
            {
                Console.WriteLine(number);
                printMultiplos3(number + 3);
            }
        }

        static void Divisivel3ou4()
        {
            for (int i = 0; i <= 30; i++)
            {
                if (i % 3 == 0 || i % 4 == 0)
                {
                    Console.WriteLine("Número: " + i);
                }
            }
        }

        static void Fatorial()
        {
            int fatorial = 1;
            for (int n = 1; n <= 10; n++)
            {
                fatorial = fatorial * n;
                Console.WriteLine("Fatorial de " + n + " é: " + fatorial);
            }
        }

        static void Fibonacci()
        {
            int ant = 1;
            for (int cont = 0; cont < 100;)
            {
                Console.WriteLine(cont + " ");
                cont += ant;
                Console.WriteLine(ant + " ");
                ant += cont;
            }
        }

        // O programa imprime os mútiplos de cada linha até chegar no valor determinado de 'n'.
        // O primeiro for representa a quantidade de "linhas"
        // o segundo for representa a quantidade de "colunas"
        // O for de dentro que representa as "colunas", executa mais de 1 vez por conta da validação "j <= i"
        // Lembre-se que quando sair do for das "colunas" e entrar novamente o j assume o valor 1, ou seja,
        // ele é reinicializado, enquanto o i do for externo está sendo iterado, então ele sempre vai 
        // executar mais um vez...
        static void ForEncadeado()
        {
            int n = 4; // número de linhas que queremos imprimir   
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i * j + " ");
                }
                Console.WriteLine("");
            }
        }  
    }
}
