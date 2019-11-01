using System;

namespace arviointi3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ohjelma laskee annettuja lukuja yhteen, kunnes sille syötetään -1");
            int lukuja=0;

            for (int i = 0; i != -1;)
            {
                Console.WriteLine("Syötä luku: ");
                i = int.Parse(Console.ReadLine());

                if (i != -1)
                {
                    lukuja += i;
                }
            }

            Console.WriteLine("Lukujen summa on: " + lukuja);
        }
    }
}
