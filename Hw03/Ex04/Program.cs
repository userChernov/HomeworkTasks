using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    /*
     * Внутри метода Main() расставьте правильно знаки + и –, чтобы значение в переменной calc стало равняться -17. 
     * Знаки нужно ставить только в той строчке, где объявляется переменная calc.
     */

    public class Program
    {
        static int a = 67;
        static int b = 11;
        static int c = 25;
        static int d = -16;
        static int e = 2;

        public static void Main(string[] args)
        {
            int calc = - a + b + c - d - e; // ТУТ НУЖНО ПРАВИЛЬНО РАССТАВИТЬ ЗНАКИ + и -
            Console.WriteLine(calc);
        }
    }
}