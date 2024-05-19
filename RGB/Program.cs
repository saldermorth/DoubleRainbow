using System;

namespace RGB
{
    class Program
    {
        public Program()
        {
            throw new System.NotImplementedException();
        }

        static void Main(string[] args)
        {
            rndColor rndCol = new rndColor();
            rndBaW BaW = new rndBaW();
            bool three = false;
            char two = ' ';
            do
            {
                Console.WriteLine("Do you like Colors or Black and white?");
                Console.WriteLine("Press 1 for Colors or 2 for BaW");
                string one = Console.ReadLine();
                three = Char.TryParse(one,  out two);

                if (two == '1')
                {
                    for (int i = 0; i < 100000; i++)
                    {
                        rndCol.randChar();

                    }
                }
                else if (two == '2')
                {
                    for (int i = 0; i < 100000; i++)
                    {
                        BaW.randCharBaW();
                    }
                }
                else
                {
                    Console.WriteLine("Choose 1 or 2");
                }

            } while (true);

        }
    }
}
