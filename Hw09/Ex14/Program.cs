using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l9t14
{
    /*
     * Внутри метода Main() объявите переменную типа DateTime. Присвойте ей дату, считанную с клавиатуры.
     * Выведите полученное значение переменной типа DateTime на экран в формате:
     * "день/месяц/год часы:минуты:секунды", например: 11/11/2011 14:01:30.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */

            DateTime date;

            date = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine(date.ToString("dd/MM/YYYY HH:MM:SS"));
        }
    }
}
