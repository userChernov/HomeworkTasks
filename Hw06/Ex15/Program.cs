using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l6t15
{
    /*
     * Создайте статический метод GetMaxValue(), который должен принимать массив целых чисел, а возвращать наибольшее из чисел в массиве.
     * Шаблон задачи менять нельзя.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(GetMaxValue(new int[] { 1, 2, 3, 3, 4, 1, 1, 231, 33, 13, 1231, 313, 2213, 31, 1, 312, 321, 1, 1, 2, 32, 3556, 6, 8576, 43, 8, 2 }));
            Console.WriteLine(GetMaxValue(new int[] { 8, 5652, -3457, 3, 34, 23, 143, 7, 647, 4, -8, 56, 75, 243, 45, 98, 65767, 252, 42351, 12, 2, 3, 1, 23, 6 }));
            Console.WriteLine(GetMaxValue(new int[] { 0 }));
        }
        /* Добавьте свой код ниже */
    }
}
