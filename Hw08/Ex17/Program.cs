using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;


namespace l8t17
{
    /*
     * Создайте статический метод GetDigitsSum(), которое принимает целое число, а возвращает сумму всех его цифр.
     * Метод GetDigitsSum() должен быть реализован рекурсивно. Использовать любые циклы запрещено.
     */


    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */

            Console.WriteLine(GetDigitsSum(111));
            Console.WriteLine(GetDigitsSum(12));
            Console.WriteLine(GetDigitsSum(9));
            Console.WriteLine(GetDigitsSum(523));
            Console.WriteLine(GetDigitsSum(99));

        }

        /* Добавьте свой код ниже */

        public static int GetDigitsSum(int a)
        {
            if (a < 10)
                return a;

            int reminder = a % 10;

            return reminder + GetDigitsSum(a / 10);
        }

    }
}
