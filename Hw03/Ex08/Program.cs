using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex8
{
    /*
     * Внутри метода Main() объявите две целочисленные переменные, присвойте им значения 5 и 17. 
     * Объявите еще 1 целочисленную переменную, присвойте ей результат умножения первых двух переменных. 
     * Выведите на экран значение третьей переменной.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            int a = 5, b =17;
            int result = a * b;

            Console.WriteLine($"Результат умножения {a} и {b} равен {result}");
        }
    }
}