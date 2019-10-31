using System;

namespace arviointi1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text;
            int number = 5;
            //ohjelma tulostaa viisi kertaa käyttäjän syöttämän sanan tai lauseen
            Console.WriteLine("syötä haluamasi sana tai lause");
            text = Console.ReadLine();
             for (int i = 0; i < number; i++)
            {
                Console.WriteLine($"{text}");
            }
        }
    }
}
