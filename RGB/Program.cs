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
            rndColor newR = new rndColor();
            for (int i = 0; i < 100000; i++)
            {
                newR.randCharColor();
            }
            newR.randCharColor();

        }
    }
}
