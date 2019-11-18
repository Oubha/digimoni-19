using System;

namespace dowhilefor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int i = 1;
            int vastaus = 1;

            Console.WriteLine("syötä luku, jonka kertoma lasketaan");
            n = int.Parse(Console.ReadLine());

            if (n >= 1)
            {
                while (i <= n)
                {
                    vastaus = (vastaus * i);
                    i++;
                }
                Console.WriteLine("vastaus on: " + vastaus);
            }
            else
            {
                Console.WriteLine("luku on liian pieni");
            }
        }
    }
}
