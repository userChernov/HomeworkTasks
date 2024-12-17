﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02
{
    /*
     * Внутри метода Main() реализуйте программу, которая:
     *      1) Считывает целое число N, введенное с клавиатуры.
     *      2) Считывает N раз целые числа, введенные с клавиатуры.
     *      3) Выводит на экран наименьшее из введенных чисел (число N не должно учитываться).
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            int min = int.MaxValue;

            Console.Write("Задайте количество чисел: ");
            int length = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < length; i++)
            {
                Console.Write($"Введите {i+1} число: ");
                int value = Convert.ToInt32(Console.ReadLine());

                min = Math.Min(min, value);
            }

            Console.WriteLine($"Наименьшее из введеных чисел: {min}");

        }
    }
}