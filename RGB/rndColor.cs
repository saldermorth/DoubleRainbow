using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGB
{
    public class rndColor
    {
        Random rnd = new Random();

        public void randChar()
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
            double randInt2 = 3.14 * randInt;

            if (randInt2<10)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else if (randInt2 < 15)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            else if (randInt2 < 20)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if (randInt2 < 45)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }

            //switch (randInt2)
            //    {
            //        case 1 > 10:
            //             Console.ForegroundColor = ConsoleColor.Red;
            //             break;
            //        case 2:
            //            Console.ForegroundColor = ConsoleColor.Blue;
            //            break;
            //        case 3:
            //            Console.ForegroundColor = ConsoleColor.Green;
            //            break;
            //        case 4:
            //            Console.ForegroundColor = ConsoleColor.Cyan;
            //            break;
            //         case 5:
            //          Console.ForegroundColor = ConsoleColor.Yellow;
            //          break;
            //        case 6:
            //            Console.ForegroundColor = ConsoleColor.DarkBlue;
            //            break;
            //        case 7:
            //            Console.ForegroundColor = ConsoleColor.DarkRed;
            //        break;
            //    default:
            //                break;
            //    }
            Console.Write(c);
            
            
           //ToDo - fractal print
        }
    }
}
