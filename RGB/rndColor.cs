using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGB
{
    class rndColor
    {
        Random rnd = new Random();

        public void randCharColor()
        {
            
            int randChar = rnd.Next(1, 5);
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
            int randInt = rnd.Next(1, 9);
            
                switch (randInt)
                {
                    case 1:
                            Console.ForegroundColor = ConsoleColor.Red;
                            break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        break;
                     case 5:
                      Console.ForegroundColor = ConsoleColor.Yellow;
                      break;
                    case 6:
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        break;
                    case 7:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                    break;
                default:
                            break;
                }
                Console.Write(c);
            
            
           //ToDo - fractal print
        }
    }
}
