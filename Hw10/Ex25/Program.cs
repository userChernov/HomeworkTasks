using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l10t25
{
    /*
     * Расставьте правильно операции преобразования примитивных типов, чтобы на экран было выведено значение 1000.
     * Значения переменных изменять нельзя.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            double d = (byte)2.50256e2d;
            char c = 'd';
            short s = (short)2.22;
            //int i = (short)150000;
            int i = (int)150000;
            float f = (short)0.50f;

            short fResult = (short)f;
            int iResult = i/c;
            double ds = d * s;

            double result = (short)f + (i / c) - (d * s) - (int)(500e-3);
            Console.WriteLine(result);
        }
    }
}

