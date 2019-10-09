using System;

namespace dfwyhteen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("syötä luku, johon asti haluat ohjelman laskevan lukuja yhteen");
            int n = int.Parse(Console.ReadLine());
            int i = 1;
            int vastaus = 0;

            if (n >= 1)
            {
                while (i <= n)
                {
                    vastaus = (vastaus + n);
                    n--;
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
