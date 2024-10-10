using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex08
{
    /* 
     * Создайте метод Compare(), который принимает в себя целое число и выводит на экран фразу:
     *  1) "Число отрицательное", если переданное число меньше нуля.
     *  2) "Число положительное", если переданное число больше нуля.
     *  3) "Введён 0!!!", если введён ноль.
     * Внутри метода Main() вызовите метод 3 раза, передавая ему в качестве аргумента числа:
     *  1) 10.
     *  2) 0.
     *  3) -777.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Compare(10);
            Compare(0);
            Compare(-777);
        }

        public static void Compare(int a)
        {
            if (a < 0)
                Console.WriteLine("Число отрицательное");
            else if (a > 0)
                Console.WriteLine("Число положительное");
            else 
                Console.WriteLine("Введён 0!!!");

        }
    }
}
