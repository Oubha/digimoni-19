using System;

namespace if1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("syötä luku");
           int userNumber = int.Parse(Console.ReadLine());
            if (userNumber %2 == 0 )
            {
                Console.WriteLine("luku on parillinen");
            }
            else
            {
                Console.WriteLine("luku on pariton");
            }
        }
    }
}
