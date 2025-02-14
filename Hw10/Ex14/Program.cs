using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l10t14
{
    /*
     * Реализуйте метод BigIntegerCalculator(), который:
     *      1) Принимает два больших целых числа в качестве входящих параметров.
     *      2) Возвращает строку, содержащую сумму принятых больших целых чисел.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Console.Write("Введите первое число: ");
            long a = long.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            long b = long.Parse(Console.ReadLine());

            string intSum = BigIntegerCalculator(a, b);

            Console.WriteLine($"Сумма чисел {a} и {b} равна {intSum}");
        }

        public static string BigIntegerCalculator(long a, long b)
        {
            string result = (a + b).ToString();

            return result;
        }
    }
}

