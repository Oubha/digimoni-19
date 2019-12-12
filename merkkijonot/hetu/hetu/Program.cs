using System;

namespace hetu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ohjelma tarkastaa hetun oikeellisuuden");
            string userInput = "131052-308T";
           int idNumber= InputParser(userInput);
            IsValidID(idNumber, 'T');
        }

        static int InputParser(string stringParser)
        {
            string removed = stringParser.Remove(10, 1);
            removed = removed.Remove(6, 1);

            return int.Parse(removed);
        }

        static bool IsValidID(int idNumber, char userInputChkMark)
        {
            string chkMark = "0123456789ABCDEFHJKLMNPRSTUVWXY";

            int modChecker = idNumber % 31;

            //vertailu onko käyttäjän syöttämä viimeinen merkki sama kuin laskettu
           if (chkMark[modChecker]==userInputChkMark)
            return true;
           else
            {
                return false;
            }
            //return chkMark[modChecker] == userInputChkMark; toinen vaihtoehto
        }

        static void PrintResult(bool isValidId)
        {
            if (isValidId)
                Console.WriteLine("sotu on oikein!");
            else
                Console.WriteLine("sotu on väärin!");

        }
    }
}
