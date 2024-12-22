using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l7t24
{
    /*
     * В  классе Program содержится 5 статических переменных, каждая из которых содержит информацию о какой-то дате.
     * Необходимо изменить метод Main() таким образом, чтобы он выводил каждую из переменных в определенном формате.
     * Формат данных указан в виде комментария напротив соответствующей строки вывода, вся информация там - произвольная!
     * Шаблон задачи изменять нельзя.
     */

    public class Clock
    {
        public static long date1 = 632900149502053008;
        public static long date2 = 612900149502083008;
        public static long date3 = 639900149507083008;
        public static long date4 = 136930149502083008;
        public static long date5 = 536900141502083008;

        public static void Main(string[] args)
        {
            Console.Clear();
            /* Добавьте свой код ниже */
            Console.WriteLine(new DateTime(date1).ToString("d MMMM yyyy", CultureInfo.CreateSpecificCulture("ru-RU"))); // 07 мая 2018 г.
            Console.WriteLine(new DateTime(date2).ToString("d MMMM yyyy", CultureInfo.CreateSpecificCulture("en-EN"))); // 01 may 2018

            // FAIL
            //Console.WriteLine(new DateTime(date3).ToString("d t", CultureInfo.CreateSpecificCulture("ru-RU"))); // 01.08.2018 01:04:07
            // FAIL
            
            Console.WriteLine(new DateTime(date4).ToString("T", CultureInfo.CreateSpecificCulture("ru-RU"))); // 17:30:30
            Console.WriteLine(new DateTime(date5).DayOfWeek); // Friday
            Console.WriteLine();
        }
    }
}

