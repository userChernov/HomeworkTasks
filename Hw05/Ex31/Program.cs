using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex31
{
    /*
     * Для класса Program создайте статический конструктор, который бы устанавливал его полям следующие значения:
     *      1)isOn = true.
     *      2)line = "It's gonna be fantastic!".
     *      3)goal = 10101.
     * Шаблон задачи изменять нельзя.
     */

    public class Program
    {
        public static bool isOn;
        public static string line;
        public static int goal = 100001;

        /* Добавьте свой код ниже */
        static Program()
        {
            isOn = true;
            line = "It's gonna be fantastic!";
            goal = 10101;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(isOn);
            Console.WriteLine(line);
            Console.WriteLine(goal);
        }
    }
}
