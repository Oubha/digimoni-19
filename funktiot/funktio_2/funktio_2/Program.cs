using System;

namespace funktio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ohjelma selvittää kahdesta luvusta pienemmän minimi-funktion avulla");
            Console.Write("syötä 1. luku:  ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("syötä 2. luku:  ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine($"luku {GetMinNumber(a, b)} on pienempi kuin luku {GetMaxNumber(a, b)}");
        }
        /// <summary>
        /// Compare two numbers and return min number.
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <returns>min number</returns>
        static int GetMinNumber(int firstNumber, int secondNumber) 
        {
            return firstNumber < secondNumber ? firstNumber : secondNumber;
            //testataan if ehdolla, kumpi luku on suurempi tai pienempi
        }
        /// <summary>
        /// Compare two numbers and return max number.
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <returns>max number</returns>
        static int GetMaxNumber(int firstNumber, int secondNumber)
        {
            int result;
            if (firstNumber > secondNumber)
            {
                result = firstNumber;
            }
            else
            {
                result = secondNumber;
            }
            return result;
        }
    }
}
