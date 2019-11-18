using System;

namespace toistorakenne2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ohjelma laskee kertotaulun luvuille 1-9");
            int i, k, p;
            for (i=1; i<=9; i++)
            {
                for (k=1; k<=9; k++)
                {
                    p = i * k;
                    Console.Write(i + "x" + k + "=" + p + " ");
                }
                Console.WriteLine("   ");
                Console.WriteLine("   ");
            }
        }
    }
}
