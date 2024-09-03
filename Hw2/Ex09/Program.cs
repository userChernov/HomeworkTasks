using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06
{
    /*
     * Внутри метода Main() последовательно сложите значения всех переменных и выведите результат в консоль.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            string s1 = "1 ";
            int a = 0;
            string s2 = " ";
            int b = 01;
            string x = " будет 101";

            /* Добавьте свой код ниже */

            string result = s1 + a;
            result += s2;
            result += b;
            result += x;

            Console.WriteLine(result);

        }
    }
}
