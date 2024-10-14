﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex15
{
    /*
     * Создайте статический метод GetMinimum() который принимает два целых числа и возвращает наименьшее из них.
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
            Console.Write("Введите первое число: ");
            int firstNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int secondNum = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine($"Самое маленькое число: {GetMinimum(firstNum, secondNum)}");
        }

        public static int GetMinimum(int a, int b)
        {
            if (a >= b) return b;
            else return a;
        }
    }
}
