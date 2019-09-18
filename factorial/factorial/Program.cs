using System;

namespace factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // define variables
            int n = 0;
            int fact = 1;

            // tulostetaan viesti käyttäjälle
            Console.WriteLine("kertoman laskenta");
            Console.Write("minkä luvun kertoma lasketaan? ");

            // luetaan käyttäjän syöte ja pakotetaan se integer muotoon
            n = int.Parse(Console.ReadLine());

            // ehto, jossa testataan käyttäjän syöttämän arvo
            // ohjelman logiikka
            if (n < 0)
            {
                Console.WriteLine("virheellinen syöte!");
            }
            else
            {
                //silmukka, jossa lasketaan kertoman arvo
                while (n > 0)
                {
                    fact = fact * n; // lasketaan kertoma joka kierroksella uudestaan
                    n = n - 1; // vähännetään arvoa yhdellä
                }
                // tulosta vastaus näytölle
                Console.WriteLine("vastaus: " + fact);
            }
            

        }
    }
}
