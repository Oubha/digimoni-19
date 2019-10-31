using System;

namespace toistorakenne5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            Console.WriteLine("ohjelma tulostaa vakioveikkauksen rivin");

            for (int i = 1; i < 14; i++)
            {
                double tulos = rnd.NextDouble();

                if (tulos <= 0.4)
                {
                    Console.WriteLine($"{i}. kotivoitto");
                }
                else if (tulos <= 0.6 && tulos > 0.4)
                {
                    Console.WriteLine($"{i}. tasapeli");
                }
                else
                {
                    Console.WriteLine($"{i}. vierasvoitto");
                }
            }
        }
    }
}
