using System;

namespace funktio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ohjelma pyytää käyttäjältä 10 positiivista kokonaislukua ja palauttaa niistä isoimman");
            string resultMessage = MaxNumberCalculator();
            Console.WriteLine($"syötit ohjelmalle seuraavat luvut :\n {resultMessage}");
        }
    }
}
