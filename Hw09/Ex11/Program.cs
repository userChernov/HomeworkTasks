using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l9t11
{
    /*
     * Создайте статический метод DivisionBy(), который принимает два целых числа и возвращает результат деления первого на второе.
     * Добавьте в метод проверку второго аргумента на равенства нулю. Если он равен нулю, то необходимо выбросить соответствующее
     * исключение.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            int a = 10;
            int b = 0;

            double result = DivisionBy(a, b);

            Console.WriteLine(result);

        }

        public static double DivisionBy(int a, int b)
        {
            double result;

            try
            {
                result = a / b;
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Ошибка исключения {ex.GetType().Name}. Сообщение: {ex.Message}");
                result = 0;
            }

            return result;

        }
    }
}
