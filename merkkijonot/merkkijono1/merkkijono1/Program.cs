using System;

namespace merkkijono1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("merkkijonon käsittelyä");
            string message = "huutista";

            //tulostetaan muuttujien merkit 'message' kohdasta yksitellen näytölle
            Console.WriteLine($"{message} on {message.Length} merkkiä pitkä.");

            for (int i = 0; i < message.Length; i++)
            {
                Console.WriteLine(message[i]);
            }
        }
    }
}
