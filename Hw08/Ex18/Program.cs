using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace l8t18
{
    /*
     * Создайте метод GetOrder(), который должен:
     *      1) Принимать целое число.
     *      2) Возвращать произведение количества четных и нечетных цифр в принятом числе.
     */


    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Console.WriteLine(GetOrder(23345));
            Console.WriteLine(GetOrder(123));
            Console.WriteLine(GetOrder(11));
            Console.WriteLine(GetOrder(222333));
        }

        public static int GetOrder(int a)
        {
            int even = 0;
            int odd = 0;
            int number;

            while (a != 0)
            {
                number = a % 10;

                if (number % 2 == 0)
                    even++;
                else
                    odd++;

                a = a / 10;
            }

            return even * odd;
        }
    }
}
