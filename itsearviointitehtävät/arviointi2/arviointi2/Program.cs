using System;

namespace arviointi2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text;

            //ohjelma tulostaa syötetyn lauseen tai sanan niin monta kertaa, kuin sanassa tai lauseessa on kirjaimia
            Console.WriteLine("syötä haluamasi sana tai lause");
            text = Console.ReadLine();

            int x = text.Length;

            for (int i = 0; i < x; i++)
            {
                Console.WriteLine(text);
            }
        }
    }
}
