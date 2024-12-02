using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex19
{
    /*
     * Добавьте в класс Program статический метод Multiply(), который возвращает результат умножения чисел 10 17 25. 
     * Тип возвращаемого значения метода Multiply() определите самостоятельно.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            int a = 10, b = 17, c = 25;
            int result = Multiply(a, b, c);
            Console.WriteLine(result);
        }
        /* Добавьте свой код ниже */

        static int Multiply(int a, int b, int c)
        {
            return a * b * c;
        }
    }
}