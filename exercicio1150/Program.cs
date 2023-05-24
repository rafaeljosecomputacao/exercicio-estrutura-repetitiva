using System;

namespace exercicio1150
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());

            while (z <= x)
            {
                z = int.Parse(Console.ReadLine());
            }

            int contador = 1;
            int soma = x;
            do
            {
                x += 1;
                soma += x;
                contador += 1;
            } while (soma <= z);

            Console.WriteLine(contador);
        }
    }
}