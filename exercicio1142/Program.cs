using System;

namespace exercicio1142
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int valor1 = 1;
            int valor2 = 2;
            int valor3 = 3;

            for (int i = 1; i <= n; i++)
            {             
                Console.Write(valor1 + " " + valor2 + " " + valor3 + " ");
                Console.WriteLine("PUM");

                valor1 = valor3 + 2;
                valor2 = valor1 + 1;
                valor3 = valor2 + 1;
            }
        }
    }
}