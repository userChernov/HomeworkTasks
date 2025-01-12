using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace l8t15
{
    /*
     * Создайте статический метод Factorial(), так чтобы он принимал целое число, а возвращал факториал полученного числа.
     * Метод Factorial() должен быть реализован рекурсивно.
     * Внутри метода Main() добавьте вывод в консоль результат вызова метода Factorial() для следующих аргументов:
     *      1) 0
     *      2) 5
     *      3) 10
     */


    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */

            Console.WriteLine(Factorial(0));
            Console.WriteLine(Factorial(5));
            Console.WriteLine(Factorial(10));
        }


        /* Добавьте свой код ниже */

        public static int Factorial(int a)
        {
            if (a == 1 || a == 0)
                return 1;

            return a * Factorial(a - 1);
        }
    }
}
