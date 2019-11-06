using System;

namespace funktio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ohjelma selvittää kahdesta annetusta luvusta pienemmän minimi -funktion avulla");
            Console.WriteLine("syötä kaksi lukua");
            int userNumber1 = int.Parse(Console.ReadLine());
            int userNumber2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Pienempi luku on: " +minimi(userNumber1, userNumber2));

        }
        public static int minimi(int userNumber1, int userNumber2)
        {

            return userNumber1 < userNumber2 ? userNumber1 : userNumber2;

        }
    }
}
