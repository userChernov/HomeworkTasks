using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace l8t13
{
    /*
     * Создайте статический метод CalcDegree(), который принимает два целых числа  А и B, а возвращает значение числа А в степени B.
     * Метод CalcDegree должен быть реализован рекурсивно.
     * Внутри метода Main() добавьте вывод в консоль результат значения метода CalcDegree() для следующих аргументов:
     *      1) 2 и 8
     *      2) 3 и 10
     *      3) 9 и 9
     * ==============================================================================================================================
     *      Не забудьте, что любое число (даже НОЛЬ) в нулевой степени - это единица, а любое число в степени 1 - это само число!
     * ==============================================================================================================================
     */


    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Console.WriteLine(CalcDegree(2, 8));
            Console.WriteLine(CalcDegree(3, 10));
            Console.WriteLine(CalcDegree(9, 9));
        }


        /* Добавьте свой код ниже */

        public static int CalcDegree(int a, int b)
        {
            int c;
            if (b == 0)
                return 1;
            else if (b == 1)
                return a;

            a = a * CalcDegree(a, b - 1);
            return a;
        }
    }
}
