using System;

namespace exercicio1144
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int primeiro = i;
                int segundo = i * i;
                int terceiro = i * i * i;
                Console.Write(primeiro + " " + segundo + " " + terceiro);
                Console.WriteLine();
           
                int quarto = i;
                int quinto = i * i + 1;
                int sexto = i * i * i + 1;
                Console.Write(quarto + " " + quinto + " " + sexto);
                Console.WriteLine();              
            }
        }
    }
}