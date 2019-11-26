using System;

namespace funktio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ohjelma pyytää käyttäjältä 10 positiivista kokonaislukua ja palauttaa niistä isoimman");
            string resultMessage = MaxNumberCalculator(ref maxNumber, ref SequenceOfNumber);
            Console.WriteLine($"syötit ohjelmalle seuraavat luvut :\n {resultMessage}");
            Console.WriteLine($"isoin luku oli {maxNumber} ja se oli {sequenceOfNumber}. luku");
        }
        static string MaxNumberCalculator(ref int maxNumber, ref int sequenceOfNumber)
        {
            //maxNumber=0;
            //sequenceOfNumber=0;
            string message = string.Empty;

            Console.WriteLine("syötä kymmenen kokonaislukua");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{i + 1}");
                string userInput = Console.ReadLine();
                bool isNumber = int.TryParse(userInput, out int userValue);

                if (isNumber)
                {
                    //generoidaan palautettava viesti annetuista luvuista
                    message = $"{message} {userValue}";
                    if (userValue > maxNumber)
                    {
                        maxNumber = userValue;
                        sequenceOfNumber = i + 1;
                    }
                    else
                    {
                        Console.WriteLine("väärä luku, kokeile uudestaan");
                        i--;
                    }
                }
                return message;
            }
        }
    }
}
