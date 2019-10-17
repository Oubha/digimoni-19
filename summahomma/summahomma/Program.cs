using System;

namespace summahomma
{
    class Program
    {
        static void Main(string[] args)
        {
            int limit, totalEven = 0, totalOdd = 0;
            Console.WriteLine("syötä luku, johon asti haluat parillisia ja parittomia lukuja laskettavan");
            limit = Convert.ToInt32(Console.ReadLine());
            for (int n = 0; n <= limit; n++)
            {
                if (n % 2 == 0)
                {
                    Console.Write(" {0} ", n);
                    totalEven = totalEven + n;
                }
                else
                {
                    Console.WriteLine(" \t {0}", n);
                    totalOdd = totalOdd + n;
                }
            }
            Console.WriteLine("\n summa kaikille parillisille luvuille on: {0} \n summa kaikille parittomille luvuille on {1} ", totalEven, totalOdd);
        }
    }
}
