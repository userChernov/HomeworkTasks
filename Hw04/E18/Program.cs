﻿using System;
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
            Random rand = new Random();

            for (int i = 0; i < 3; i++)
            {
                int firstNum = rand.Next(1, 100);
                Console.WriteLine(firstNum);
                int secondNum = rand.Next(1, 100);
                Console.WriteLine(secondNum);
                int thirdNum = rand.Next(1, 100);
                Console.WriteLine(thirdNum);
                int fourthNum = rand.Next(1, 100);
                Console.WriteLine(fourthNum);
                
                Console.WriteLine($"Самое маленькое число: {GetMinimum(firstNum, secondNum, thirdNum, fourthNum)}");
            }
        }


        // запутался!
        public static int GetMinimum(int a, int b, int c, int d)
        {
            int[] numbers = new int[] {a, b, c, d};
            return numbers.Min();

        }
    }
}
