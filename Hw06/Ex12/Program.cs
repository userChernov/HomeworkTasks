using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l6t12
{
    /*
     * Внутри метода Main() выведите в консоль результат перемножения всех статических переменных класса Program, при этом все
     * переменные перед умножением должны быть изменены с использованием методов Change: целые числа и символы - по ссылке, дробные по значению.
     * Шаблон задачи изменять нельзя.
     */

    public class Program
    {
        static int a = 10;
        static long b = 17;
        static double d = 10.11;
        static float f = 100.07f;
        static char c = 'q';

        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Console.WriteLine(a * b * f * c);
            
            Change(ref a);
            Change(ref b);
            Change(f);
            Change(ref c);

            Console.WriteLine(a * b * f * c);
        }

        public static void Change(int a)
        {
            a += a;
        }

        public static void Change(ref int a)
        {
            a += a;
        }

        public static void Change(long a)
        {
            a += a;
        }

        public static void Change(ref long a)
        {
            a += a;
        }

        public static void Change(double a)
        {
            a += a;
        }

        public static void Change(ref double a)
        {
            a += a;
        }

        public static void Change(float a)
        {
            a += a;
        }

        public static void Change(ref float a)
        {
            a += a;
        }

        public static void Change(char a)
        {
            a += a;
        }

        public static void Change(ref char a)
        {
            a += a;
        }
    }
}
