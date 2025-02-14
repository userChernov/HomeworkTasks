using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace l10t13
{
    /*
     * Создайте метод IsInDegree(), который:
     *      1) Принимает большое целое число в качестве входящего параметра.
     *      2) Возвращает логическое значение: true - если принятое число является числом 2 в целой степени и false если нет.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            long number = long.Parse(Console.ReadLine());

            if (IsInDegree(number))
            {
                Console.WriteLine($"Число {number} является числом 2 в целой степени");
            }
            else
            {
                Console.WriteLine($"Число {number} НЕ является числом 2 в целой степени");
            }

        }

        /* Добавьте свой код ниже */

        public static bool IsInDegree(long number)
        {
            bool result = false;

            int i = 1;
            while (true)
            {
                if (number == Math.Pow(2, i))
                {
                    result = true;
                    break;
                }
                else if (number < Math.Pow(2, i))
                {
                    break;
                }

                i++;
            }

            return result;
        }
    }
}

