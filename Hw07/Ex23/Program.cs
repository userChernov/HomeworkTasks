using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l7t23
{
    /*
     * Реализуйте статический метод FindDay() который должен:
     *      1) Принимать значение типа DateTime.
     *      2) Выводить на экран день недели, который будет через 33 дня после полученной даты.
     * Вывод должен осуществляться на английском языке.
     * Шаблон задачи изменять нельзя.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            FindDay(DateTime.Parse("10.11.11"));
            FindDay(DateTime.Parse("31.12.24"));
            FindDay(DateTime.Parse("17.06.19"));
        }

        public static void FindDay(DateTime date)
        {
            /* Добавьте свой код ниже */
            Console.WriteLine((date.AddDays(33)).DayOfWeek);

        }
    }
}
