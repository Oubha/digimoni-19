using System;

namespace funktio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ohjelma tulostaa syötetyn luvun verran tähtiä");
            Console.Write("syötä kokonaisluku: ");
            int userInput = int.Parse(Console.ReadLine());
            if(IsValidNumber(userInput))
            {
                string strStars = Star(userInput);
                Console.WriteLine(strStars);
            }
             else
            {
                Console.WriteLine($"numero {userInput} ei ole sallittu luku");
            }
        }
        static bool IsValidNumber(int userInput)
        {
            if (userInput > 0)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// ohjelma generoi parametrin määrän tähtiä
        /// </summary>
        /// <param name="amauntOfStars"></param>
        /// <returns></returns>
        static string Star(int amauntOfStars)
        {
            string stars = "";
            for (int i = 0; i<amauntOfStars; i++)
            {
                stars = stars + "*";
                //stars += "*";
            }
            return stars;
        } 
    }
}
