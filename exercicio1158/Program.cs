using System;

namespace exercicio1158
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < n; i++)
            {
                string[] vetor = Console.ReadLine().Split(' ');
                int x = int.Parse(vetor[0]);
                int y = int.Parse(vetor[1]);

                int soma = 0;
                int contador = 0;

                for (int j = x; contador < y; j++)
                {
                    if (j % 2 != 0)
                    {
                        soma += j;
                        contador += 1;
                    }
                }

                Console.WriteLine(soma);
            }
        }
    }
}