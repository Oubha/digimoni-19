using System;

namespace summahomma
{
    class Program
    {
        static void Main(string[] args)
        {
            int limit, totalEven = 0, totalOdd = 0;
            int k = 1;

            Console.WriteLine("syötä luku, johon asti haluat parillisia ja parittomia lukuja laskettavan");
            limit = Convert.ToInt32(Console.ReadLine());
            if (limit < 0)
            {
                k = -1;
            }

            for (int n = 0; n <= limit * k; n++)
            {
                if (n % 2 == 0)
                {
                    Console.Write(" {0} ", n * k);
                    totalEven = totalEven + n * k;
                }
                else
                {
                    Console.WriteLine(" \t {0}", n * k);
                    totalOdd = totalOdd + n * k;
                }

            }
            Console.WriteLine("\n summa kaikille parillisille luvuille on: {0} \n summa kaikille parittomille luvuille on {1} ", totalEven, totalOdd);
        }
    }
}
