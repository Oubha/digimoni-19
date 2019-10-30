using System;

namespace toistorakenne4
{
    class Program
    {
        static void Main(string[] args)
        {
            //ohjelma simuloi kolikon heittoa
            Random rnd = new Random();

            int n;
            int i = 0;

            int kruuna = 0;
            int klaava = 0;

            Console.WriteLine("ohjelma laskee kolikon heittoa satunnaisesti");
            Console.WriteLine("montako heittoa haluat?");
            n = int.Parse(Console.ReadLine()); //heittojen määrä, käyttäjän syöttämä luku

            for (i = 0; i < n; i++)
            {
                int tulos = rnd.Next(2); 
                if (tulos == 1)
                {
                    klaava++; //heitto oli klaava
                }
                else if (tulos == 0)
                {
                    kruuna++; //heitto oli kruuna
                }
            }
            Console.WriteLine("kolikkoa on heitetty " + n + " kertaa");
            Console.WriteLine("klaavoja heitettiin " + klaava);
            Console.WriteLine("kruunoja heitettiin " + kruuna);
        }
    }
}
