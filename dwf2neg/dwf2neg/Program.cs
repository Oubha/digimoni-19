using System;

namespace dwf2neg
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("syötä luku, johon asti lisätään tai vähennetään");
            int i = int.Parse(Console.ReadLine());
            int n = 0;
            int p = 0;

            if (i > 0)
            {
                while (n <= i)
                {
                    p = (p + n);
                    n++;
                }
                Console.WriteLine($"tulos on: {p}");
            }
            else
            {
                if (i < 0)
                {
                    while (n >= i)
                    {
                        p = (p + n);
                        n--;
                    }
                    Console.WriteLine($"tulos on; {p}");
                }
            }
        }
    }
}
