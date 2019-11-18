using System;

namespace toistorakenne6
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            Console.WriteLine("ohjelma simuloi nopan heittoa 1000 kertaa");
            Console.WriteLine("tämän lisäksi ohjelma tulostaa numeron 6 esiintymiskerrat");

            int kuus = 0;

            for (int n = 0; n <= 1000; n++) //noppaa heitetään tuhat kertaa
            {
                int tulos = rnd.Next(6);

                Console.WriteLine($"{n}. {tulos + 1}");
                if (tulos + 1 == 6)
                {
                    kuus++;
                }
            }
            Console.WriteLine($"numero 6 esiintyi heitoissa yhteensä {kuus} kertaa");
        }
    }
}
