using System;

namespace toistorakenne1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ohjelma tulostaa kokonaisluvut ja neliöjuuret luvuille 1-10");
            Console.WriteLine("luku |    neliöjuuri");
            double i = 0;

            while (i <= 10)
            {
                double nelio = Math.Sqrt(i);
                Console.WriteLine($"{i}    |    {nelio}");
                i++;
            }
            return;
        }
    }
}
