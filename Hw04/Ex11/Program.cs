﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11
{
    /*
     *  Реализуйте  метод CheckYear(), который принимает в себя целочисленную переменную - год и выводит в консоль:
     *      1) "Год ХХХ является високосным".
     *      2) "Год ХХХ является НЕ високосным".
     *  ХХХ - переданное при вызове метода значение.
     *  ===========================================================================================================
     *  Високосным годом является каждый четвёртый год, за исключением годов, которые кратны 100 и не кратны 400.
     *  Так, годы 1700, 1800 и 1900 не являются високосными, так как они кратны 100 и не кратны 400.
     *  Годы 1600 и 2000 - високосные, так как они кратны 100 и кратны 400.
     *  Годы 2100, 2200 и 2300 - не високосные.
     *  ===========================================================================================================         
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            int year = Convert.ToInt32(Console.ReadLine());

            CheckYear(year);
            
        }

        public static void CheckYear(int year)
        {
            if (year % 4 != 0)
                Console.WriteLine($"Год {year} является НЕ високосным");
            else if (year % 100 != 0)
                Console.WriteLine($"Год {year} является високосным");
            else if (year % 400 != 0)
                Console.WriteLine($"Год {year} является НЕ високосным");
            else
                Console.WriteLine($"Год {year} является високосным");

        }

        /* Добавьте свой код ниже */
    }
}
