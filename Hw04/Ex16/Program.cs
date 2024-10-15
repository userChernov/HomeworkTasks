﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex16
{
    /*
     *  Создайте статический метод GetMaximum() который принимает два целых числа и возвращает наибольшее из них.
     * Внутри метода Main() 3 раза выведите в консоль результат вызовов метода GetMaximum() в следующем формате:
     * "Самое большое число: ХХХ", где ХХХ - результат вызова метода GetMaximum().
     * Каждый из выводов результата вызова метода GetMaximum() должен осуществляться с новой строки и с различными аргументами.
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
                
                Console.WriteLine($"Самое большое число: {GetMaximum(firstNum, secondNum)}");
            }
        }

        public static int GetMaximum(int a, int b)
        {
            if (a <= b) return b;
            else return a;
        }
    }
}
