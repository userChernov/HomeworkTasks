using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex09
{
    /*
     * Создайте метод CheckInterval(), который должен принимать целое число и выводить в консоль:
     *   1) "Число ХХХ не содержится в интервале.", если число не входит в интервал от 30 до 100 включительно.
     *   2) "Число ХХХ содержится в интервале.", если число входит в интервал от 30 до 100 включительно.
     * ХХХ - значение, переданное при вызове метода CheckInterval().
     * Внутри метода Main() вызовите метод CheckInterval() 4 раза, передав ему в качестве аргумента:
     *   1) 10.
     *   2) 30.
     *   3) 1000.
     *   4) 100.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            CheckInterval(10);
            CheckInterval(30);
            CheckInterval(1000);
            CheckInterval(100);
        }

        public static void CheckInterval(int a)
        {
            if (a > 30 && a <= 100)
                Console.WriteLine($"Число {a} содержится в интервале.");
            else 
                Console.WriteLine($"Число {a} не содержится в интервале.");

        }
    }
}