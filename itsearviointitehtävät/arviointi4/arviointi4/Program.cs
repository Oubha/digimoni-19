using System;

namespace arviointi4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ohjelma suorittaa annetuille luvuille perusaritmeettiset toiminnot");
            Console.WriteLine("ja tulostaa vastaukset kahden desimaalin tarkkuudella");

            Console.Write("eka luku:  "); //syötetään ohjelmalle ensimmäinen luku
            double a = double.Parse(Console.ReadLine());
            Console.Write("toka luku:  "); //syötetään ohjelmalle toinen luku
            double b = double.Parse(Console.ReadLine());

            //perusaritmeettiset toiminnot
            Console.WriteLine($"{a} + {b} = {a + b:F2}");
            Console.WriteLine($"{a} - {b} = {a - b:F2}");
            Console.WriteLine($"{a} * {b} = {a * b:F2}");
            Console.WriteLine($"{a} / {b} = {a / b:F2}");
        }
    }
}

