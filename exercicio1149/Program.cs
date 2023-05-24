using System;

namespace exercicio1149
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, N, i, soma;

            string[] vetor = Console.ReadLine().Split(' ');
            A = int.Parse(vetor[0]);
            i = 1;
            N = int.Parse(vetor[i]);
            while (N <= 0)
            {
                i = i + 1;
                N = int.Parse(vetor[i]);
            }

            soma = 0;

            for (i = 0; i < N; i++)
            {
                soma = soma + A + i;
            }

            Console.WriteLine(soma);
        }
    }
}