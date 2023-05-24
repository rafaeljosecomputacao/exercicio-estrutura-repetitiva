using System;
using System.Globalization;

namespace exercicio1094
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int totalCobaias = 0;
            int totalCoelhos = 0;
            int totalRatos = 0;
            int totalSapos = 0;

            for (int i = 1; i <= n; i++)
            {
                string[] vetor = Console.ReadLine().Split(' ');
                int quantidade = int.Parse(vetor[0]);
                char tipo = char.Parse(vetor[1]);

                totalCobaias += quantidade;

                if (tipo == 'C')
                {
                    totalCoelhos += quantidade;
                }
                else if (tipo == 'R')
                {
                    totalRatos += quantidade;
                }
                else
                {
                    totalSapos += quantidade;
                }
            }

            double percentualCoelhos = (double) totalCoelhos / totalCobaias * 100.0;
            double percentualRatos = (double) totalRatos / totalCobaias * 100.0;
            double percentualSapos = (double) totalSapos / totalCobaias * 100.0;

            Console.WriteLine("Total: " + totalCobaias + " cobaias");
            Console.WriteLine("Total de coelhos: " + totalCoelhos);
            Console.WriteLine("Total de ratos: " + totalRatos);
            Console.WriteLine("Total de sapos: " + totalSapos);
            Console.WriteLine("Percentual de coelhos: " + percentualCoelhos.ToString("F2", CultureInfo.InvariantCulture) + " %");
            Console.WriteLine("Percentual de ratos: " + percentualRatos.ToString("F2", CultureInfo.InvariantCulture) + " %");
            Console.WriteLine("Percentual de sapos: " + percentualSapos.ToString("F2", CultureInfo.InvariantCulture) + " %");
        }
    }
}