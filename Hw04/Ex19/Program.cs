using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex19
{
    /*
     * Создайте статический метод SortedTrio(), который принимает три целочисленных параметра и выводит их в консоль в порядке убывания.
     * Вывод чисел должен осуществляться в одной строке через пробел с последующим переносом указателя на новую строку.
     * Внутри метода Main() вызовите метод SortedTrio() со следующими значениями аргументов:
     *    1) 11,0,16.
     *    2) 12,-156,5.
     *    3) 33, 33,12.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            SortedTrio(11, 0, 16);
            SortedTrio(12, -156, 5);
            SortedTrio(33, 33, 12);
        }

        /* Добавьте свой код ниже */
        public static void SortedTrio(int one, int two, int three)
        {
            if (one >= two && one >= three)
            {
                if (two >= three) Console.WriteLine($"{one} {two} {three}");
                else Console.WriteLine($"{one} {three} {two}");
            } 
            else if (two >= one && two >= three)
            {
                if (one >= three) Console.WriteLine($"{two} {one} {three}");
                else Console.WriteLine($"{two} {three} {one}");
            } 
            else 
            {
                if (one >= two) Console.WriteLine($"{three} {one} {two}");
                else Console.WriteLine($"{three} {two} {one}");
            }
        }

    }
}
