using System;

namespace exercicio1072
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int somain = 0;
            int somaout = 0;

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());

                if (x >= 10 && x <= 20)
                {
                    somain += 1;
                }
                else
                {
                    somaout += 1;
                }
            }

            Console.WriteLine(somain + " in");
            Console.WriteLine(somaout + " out");
        }
    }
}