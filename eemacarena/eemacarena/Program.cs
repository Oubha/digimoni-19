using System;

namespace eemacarena
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("syötä luku");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            if (userNumber > 0)
            {
                Console.WriteLine("numero on positiivinen");
            }
            else if (userNumber == 0)
                Console.WriteLine("numero on 0");
             
            else
            {
                Console.WriteLine("numero on negatiivinen");
            }
       
            

          
        }
    }
}
