using System;

namespace exercicio1080
{
    class Program
    {
        static void Main(string[] args)
        {
            int maior = 0;
            int posicao = 0;

            for (int i = 1; i <= 100; i++)
            {
                int valor = int.Parse(Console.ReadLine());

                if (valor > maior) 
                { 
                    maior = valor;
                    posicao = i;
                }
            }

            Console.WriteLine(maior);
            Console.WriteLine(posicao);
        }
    }
}