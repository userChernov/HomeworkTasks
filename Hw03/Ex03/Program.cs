using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    /*
     * Внутри метода Main() последовательно считайте 3 числа и присвойте их
     * трем целочисленным переменным с произвольными именами. 
     * Выведите на экран сумму этих трех чисел.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите последовательно 3 числа:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Сумма чисел {a}, {b} и {c} равна {a + b + c}");
        }
    }
}