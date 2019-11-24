using System;

namespace funktio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int retNumber = numberFromRange(1, 50);

            Console.WriteLine($"syötetty luku {retNumber} on annetulta väliltä!");

        }
        static int numberFromRange(int lowerBound, int upperBound)
        {
            bool isNumber;
            int input = 0;

            do
            {
                Console.WriteLine($"syötä luku väliltä {lowerBound} ja {upperBound}: ");
                isNumber = int.TryParse(Console.ReadLine(), out input);

                if (input <= upperBound && input >= lowerBound)
                {
                    break;
                }
                else
                {
                    isNumber = false;
                    Console.WriteLine($"annettu luku ei ole luku tai väliltä {lowerBound} ja {upperBound}. Yritä uudestaan");
                }
            }
            while (isNumber == false);
            return input;
        }
    }
}
