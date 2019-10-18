using System;

namespace if1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("syötä luku");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            if (userNumber > 0)
            {
                Console.WriteLine("luku on positiivinen");
            }
            else if (userNumber == 0)
                Console.WriteLine("luku on nolla");

            else
            {
                Console.WriteLine("luku on negatiivinen");
            }
        }
    }
}
