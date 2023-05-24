using System;

namespace exercicio1097
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 7;
            int max = 5;

            for (int i = 1; i <= 9; i += 2)
            {
                for (int j = min; j >= max; j--)
                {
                    Console.Write("I=" + i + " J=" + j + "\n");
                }

                min += 2;
                max += 2;
            }
        }
    }
}