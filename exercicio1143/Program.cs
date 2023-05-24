using System;

namespace exercicio1143
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int valor1 = i;
                int valor2 = i * i;
                int valor3 = i * i * i;
                Console.Write(valor1 + " " + valor2 + " " + valor3);
                Console.WriteLine();
            }
        }
    }
}