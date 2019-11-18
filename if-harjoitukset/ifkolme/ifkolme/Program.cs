using System;

namespace ifkolme
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
     
            if (userNumber > 0)
            {
                Console.WriteLine("luku on positiivinen");
            }
            else if (userNumber == 0)
                Console.WriteLine("numero on 0");
            else
            {
                Console.WriteLine("luku on negatiivinen");
            }
        }
    }
}
