using System;

namespace kakkonen
{
    class Program
    {
        static void Main(string[] args)
        {
            int userNumber;
            Console.WriteLine("syötä luku");
            userNumber = int.Parse(Console.ReadLine());
            if (userNumber % 2 == 0)
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
