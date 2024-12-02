using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex20
{
    /*
     * Создайте статический метод Statistic() который принимает три целочисленных параметра и возвращает:
     *      1) 0, если все три параметра имеют различные значения.
     *      2) Порядковый номер числа, отличного от других, если два других числа имеют одинаковые значения.
     *      3) -1, если все три параметра имеют одинаковое значение.
     * Внутри метода Main() выведите в консоль результат вызова метода Statistic() со следующими значениями аргументов:
     *      1) 12,12,5.
     *      2) 11,0,16.
     *      3) 33,33,33.
     * Вывод каждого элемента должен осуществляться с новой строки.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Console.WriteLine(Statistic(12, 12, 5));
            Console.WriteLine(Statistic(11, 0, 16));
            Console.WriteLine(Statistic(33, 33, 33));
        }

        /* Добавьте свой код ниже */
        public static int Statistic(int a, int b, int c)
        {
            if (a != b && a != c && b != c)
                return 0;
            else if (a == b && a == c && b ==c)
                return -1;
            else 
            {
                if (a == b && a != c)
                    return 3;
                else if (b == c && b != a)
                    return 1;
                else 
                    return 2;
            }
        }
    }
}
