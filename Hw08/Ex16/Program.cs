using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace l8t16
{
    /*
     * Создайте статический метод Factorial(), так чтобы он принимал целое число, а возвращал факториал полученного числа.
     * Метод Factorial() должен быть реализован итеративно.
     * Внутри метода Main() добавьте вывод в консоль результат значения метода Factorial() для следующих аргументов:
     *      1) 10
     *      2) 12
     *      3) 7
     */


    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Console.WriteLine(Factorial(10));
            Console.WriteLine(Factorial(12));
            Console.WriteLine(Factorial(7));
        }


        /* Добавьте свой код ниже */
        public static int Factorial(int a)
        {
            if (a == 0 || a == 1)
                return 1;

            int x = 1;
            for (int i = 1; i < a + 1; i++)
            {
                x = x * i;
            }

            return x;
        }

    }
}
