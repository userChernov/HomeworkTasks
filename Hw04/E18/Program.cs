using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex18
{
    /*
     * Создайте статический метод GetMinimum(), который принимает четыре целых числа и возвращает наименьшее из них.
     * Внутри метода Main() 3 раза выведите в консоль результат вызовов метода GetMinimum() в следующем формате:
     * "Самое маленькое число: ХХХ", где ХХХ - результат вызова метода GetMinimum().
     * Каждый из выводов результата работы метода GetMinimum() должен осуществляться с новой строки и с различными аргументами.
     * Если числа равны - выведите любое из них.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */

            for (int i = 0; i < 3; i++)
            {
                Random rand = new Random();

                int firstNum = rand.Next();
                int secondNum = rand.Next();
                int thirdNum = rand.Next();
                int fourthNum = rand.Next();
                
                Console.WriteLine($"Самое большое число: {GetMinimum(firstNum, secondNum, thirdNum, fourthNum)}");
            }
        }


        // запутался!
        public static int GetMinimum(int a, int b, int c, int d)
        {
            if (a < b)
            {
                if (a < c && a < d) return a;
                else if (d < a && d < c) return d;
                else return c;
            }
            else if (b < a)
            {

            }
        }
    }
}
