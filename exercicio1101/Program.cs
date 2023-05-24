using System;

namespace exercicio1101
{
    class Program
    {
        static void Main(string[] args)
        {
            int M, N;

            do
            {
                string[] vetor = Console.ReadLine().Split(' ');
                M = int.Parse(vetor[0]);
                N = int.Parse(vetor[1]);

                if (M > 0 && N > 0)
                {
                    int soma = 0;
                    int menor = 0;
                    int maior = 0;

                    if (M < N)
                    {
                        menor = M;
                        maior = N;
                    }
                    else
                    {
                        menor = N;
                        maior = M;
                    }

                    for (int j = menor; j <= maior; j++)
                    {
                        Console.Write(j + " ");
                        soma += j;
                    }

                    Console.WriteLine("Sum=" + soma);
                }
            } while (M > 0 && N > 0);
        }
    }
}