using System;

namespace exercicio1099
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string[] vetor = Console.ReadLine().Split(' ');
                int x = int.Parse(vetor[0]);
                int y = int.Parse(vetor[1]);

                int soma = 0;
                int menor = 0;
                int maior = 0;

                if (x < y)
                {
                    menor = x;
                    maior = y;
                }
                else
                {
                    menor = y;
                    maior = x;
                }

                for (int j = menor + 1; j < maior; j++)
                {
                    if (j % 2 != 0)
                    {
                        soma += j;
                    }
                }

                Console.WriteLine(soma);
            }
        }
    }
}