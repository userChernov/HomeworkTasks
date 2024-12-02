using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01
{
    /*
     * Внутри метода Main() создайте программу, которая считывает 5 чисел с клавиатуры
     * и выводит в консоль наименьшее из них.
     */
    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            int min = int.MaxValue;

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Введите {i+1} число: ");
                int number = Convert.ToInt32(Console.ReadLine());

                if (number < min)
                    min = number;
            }

            Console.WriteLine($"Наименьшее из введнных чисел: {min}"); 
        }
    }
}
