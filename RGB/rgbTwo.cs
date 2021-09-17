using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGB
{
    public class rndBaW
    {
        public void randCharBaW()
        {
            Random rnd2 = new Random();
            int randChar = rnd2.Next(1, 5);
            char k = ' ';

            switch (randChar)
            {
                case 1:
                    k = '¥';
                    break;
                case 2:
                    k = 'Œ';
                    break;
                case 3:
                    k = 'Ŧ';
                    break;
                case 4:
                    k = 'Ƣ';
                    break;
                default:
                    k = ' ';
                    break;
            }

            rgbPrint(k);

        }
        public void rgbPrint(char c)
        {
            Random rnd = new Random();
            int randInt = rnd.Next(1, 9);
            double randInt2 = 3.14 * randInt;

            if (randInt2 < 10)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            else if (randInt2 < 15)
            {
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (randInt2 < 20)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
            }
            else if (randInt2 < 45)
            {
                Console.ForegroundColor = ConsoleColor.Black;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }

            
            Console.Write(c);

          }
        }
    }
