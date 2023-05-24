using System;
using System.Globalization;

namespace exercicio1154
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade, somaIdades, contador;
            double media;

            idade = int.Parse(Console.ReadLine());

            somaIdades = 0;
            contador = 0;

            while (idade > 0)
            {
                somaIdades += idade;
                contador += 1;
                idade = int.Parse(Console.ReadLine());
            }

            media = (double) somaIdades / contador;

            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}