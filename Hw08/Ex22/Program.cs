using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace l8t22
{
    /*
     * Создайте статический метод GetRoundCount() который принимает целое число и возвращает количество замкнутых фигур
     * в принятом числе.
     * ==========================================================================================================
     *  Например число 0 и 8 - имеют 2 замкнутых "кружка" и т.д.
     * ==========================================================================================================
     */

     /*
        0 - 2
        1 - 0
        2 - 0
        3 - 0
        4 - 1
        5 - 0
        6 - 1
        7 - 0
        8 - 2
        9 - 1
     */


    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Console.Clear();
            
            Console.WriteLine(GetRoundCount(123));
            Console.WriteLine(GetRoundCount(456));
            Console.WriteLine(GetRoundCount(7890));
            Console.WriteLine(GetRoundCount(0123456789));
            Console.WriteLine(GetRoundCount(1234567890));
        }

        public static int GetRoundCount(int number)
        {
            int roundCount = 0;

            while (number != 0)
            {
                int digit = number % 10;
                number = number / 10;

                switch (digit)
                {
                    case 0:
                        roundCount += 2;
                        break;
                    case 4:
                        roundCount += 1;
                        break;
                    case 6:
                        roundCount += 1;
                        break;
                    case 8:
                        roundCount += 2;
                        break;
                    case 9:
                        roundCount += 1;
                        break;
                }
            }

            return roundCount;
        }
    }
}
