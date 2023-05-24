using System;

namespace exercicio1159
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            while (x != 0)
            {
                if (x % 2 != 0)
                {
                    x += 1;
                }

                int somaPares = 5 * x + 20;

                Console.WriteLine(somaPares);

                x = int.Parse(Console.ReadLine());
            }
        }
    }
}