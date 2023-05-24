using System;

namespace exercicio1132
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, menor, maior, soma;

            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

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

            soma = 0;

            for (int i = menor; i <= maior; i++)
            {             
                if (i % 13 != 0)
                {
                    soma += i;
                }
            }

            Console.WriteLine(soma);
        }
    }
}