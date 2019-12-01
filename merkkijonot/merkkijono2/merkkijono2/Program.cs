using System;

namespace merkkijono2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ohjelma muuttaa syötteen 'e' kirjaimet '@' merkiksi");
            Console.WriteLine("syötä jokin sana tai lause");
            string message = Console.ReadLine();

            //ohjelma vaihtaa kaikki eet @-merkiksi
            char[] array = message.ToCharArray();
            for (int i = 0; i < array.Length; i++)
            {
                char let = array[i];
                if (char.IsUpper(let))
                {
                    array[i] = char.ToLower(let);
                }
                else if (let == ' ')
                {
                    array[i] = '-';
                }
                else if (let == 'e')
                {
                    array[i] = '@';
                }
            }
            string result = new string(array);
            Console.WriteLine(result);
        }
    }
}
