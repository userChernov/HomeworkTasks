using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l7t22
{
    /*
     * Реализуйте статический метод GetSeconds() который должен:
     *      1) Принимать два объекта типа DateTime.
     *      2) Возвращать количество милисекунд, которое прошло между двумя принятыми датами.
     * Шаблон задачи изменять нельзя.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            Console.WriteLine(GetSeconds(now, now.Add(new TimeSpan(10000))));
            Console.WriteLine(GetSeconds(now, now.Add(new TimeSpan(20000))));
            Console.WriteLine(GetSeconds(now, now.Add(new TimeSpan(50000))));
        }

        public static long GetSeconds(DateTime dateA, DateTime dateB)
        {
            /* Добавьте свой код ниже */
            
            return (dateB - dateA).Milliseconds;
        }
    }
}

