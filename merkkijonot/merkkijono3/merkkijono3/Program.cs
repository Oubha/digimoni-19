using System;

namespace merkkijono3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ohjelma laskee syötetystä sanasta tai lauseesta k kirjainten määrän");
            string message = Console.ReadLine();
            int count = 0;
            char charToCount = 'k';
            foreach (char k in message)
            {
                if (k == charToCount)
                {
                    count++;
                }
            }
            Console.WriteLine($"{message}-syötteessä on {count} k kirjainta");
        }
    }
}
