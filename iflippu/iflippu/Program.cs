using System;

namespace iflippu
{
    class Program
    {
        static void Main(string[] args)
        {
            double discount = 0;
            string isConscript;
            string isStudent;
            string isMtkMember;
            int a = 16;
            int b = 0;

            Console.WriteLine("hei, lasketaa sulle ale");
            Console.Write("oletko varusmies? Y / N");
            isConscript = Console.ReadLine();
            if (isConscript.ToUpper() == "Y")
            {
                discount = 0.5;
                Console.WriteLine($"lipun hinta on {a - (a * discount)}euroa");
            }
            else
            {
                Console.WriteLine("oletko opiskelija? Y/N");
                isStudent = Console.ReadLine();
                if (isStudent.ToUpper() == "Y")
                {
                    Console.WriteLine("oletko Mtk:n jäsen? Y / N");
                    isMtkMember = Console.ReadLine();
                    if (isMtkMember.ToUpper() == "Y")
                    {
                        discount = 0.6;
                        Console.WriteLine($"lipun hinta on {a - (a * discount)}euroa");
                    }
                    else
                    {
                        discount = 0.45;
                        Console.WriteLine($"lipun hinta on {a - (a * discount)}euroa");
                    }
                }
                else
                {
                    Console.WriteLine("syötä ikäsi");
                    b = int.Parse(Console.ReadLine());
                    if (b <= 15 && b > 7)
                    {
                        discount = 0.5;
                        Console.WriteLine($"lipun hinta on {a - (a * discount)} euroa");
                    }
                    else if (b >= 65)
                    {
                        discount = 0.5;
                        Console.WriteLine($"lipun hinta on {a - (a * discount)} euroa");
                    }
                    else if (b <= 7)
                    {
                        discount = 1;
                        Console.WriteLine($"lipun hinta on {a - (a * discount)} euroa");
                    }
                    else
                    {
                        Console.WriteLine("oletko Mtk:n jäsen?");
                        isMtkMember = Console.ReadLine();
                        if (isMtkMember.ToUpper() == "Y")
                        {
                            discount = 0.15;
                            Console.WriteLine($"lipun hinta on {a - (a * discount)} euroa");
                        }
                        else
                        {
                            Console.WriteLine("lipun hinta on 16 euroa");
                        }
                    }
                }
            }
        }
    }
}

