using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l6t8
{
    /*
     * Внутри класса Program создайте статический метод Dif, который:
     *      1) Ничего не возвращает.
     *      2) Имеет два входящих целочисленных параметра и один исходящий.
     *      3) Исходящему параметру должен присваиваться результат разности первого и второго входящего параметра.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */

            int val1 = 5, val2 = 2;
            int val3;

            Dif(val1, val2, out val3);

            Console.WriteLine(val3);
        }

        public static void Dif(int enterValue1, int enterValue2, out int outValue)
        {
            outValue = enterValue1 - enterValue2;
        }
    }
}
