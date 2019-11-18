using System;

namespace toistorakenne3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int n = 1;
            Console.WriteLine("ohjelma tulostaa 20 satunnaista kokonaislukua väliltä 0-50");
            Random rnd = new Random();

            while (n <= 5)
            {
                Console.Write("rivi " + n + ": ");

                while (i < 4)
                {
                    Console.WriteLine(rnd.Next(50) + ", ");
                    i++;
                    
                    if (i == 4)
                    {
                        Console.WriteLine(rnd.Next(50) + ", ");
                    }
                }
                i = 0;
                n++;
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
