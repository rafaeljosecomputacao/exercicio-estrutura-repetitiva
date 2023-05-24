using System;

namespace exercicio1133
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, menor, maior;

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

            for (int i = menor + 1; i < maior; i++)
            {
                if (i % 5 == 2 || i % 5 == 3)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}