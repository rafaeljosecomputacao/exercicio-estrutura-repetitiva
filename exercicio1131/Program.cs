using System;

namespace exercicio1131
{
    class Program
    {
        static void Main(string[] args)
        {
            int vitoriasInter = 0;
            int vitoriasGremio = 0;
            int empates = 0;
            int novoGrenal = 1;

            while (novoGrenal == 1)
            {
                string[] vetor = Console.ReadLine().Split(' ');
                int golsInter = int.Parse(vetor[0]);
                int golsGremio = int.Parse(vetor[1]);

                if (golsInter > golsGremio)
                {
                    vitoriasInter += 1;
                }
                else if (golsInter < golsGremio)
                {
                    vitoriasGremio += 1;
                }
                else 
                { 
                    empates += 1;
                }

                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                novoGrenal = int.Parse(Console.ReadLine());
            }

            int totalJogos = vitoriasInter + vitoriasGremio + empates;

            Console.WriteLine(totalJogos + " grenais");
            Console.WriteLine("Inter:" + vitoriasInter);
            Console.WriteLine("Gremio:" + vitoriasGremio);
            Console.WriteLine("Empates:" + empates);

            if (vitoriasInter > vitoriasGremio)
            {
                Console.WriteLine("Inter venceu mais");
            }
            else if (vitoriasInter < vitoriasGremio)
            {
                Console.WriteLine("Gremio venceu mais");
            }
            else
            {
                Console.WriteLine("Nao houve vencedor");
            }
        }
    }
}