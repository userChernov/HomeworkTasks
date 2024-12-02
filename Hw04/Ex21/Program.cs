using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex21
{
    /*
     * Внутри метода Main() реализуйте следующую логику работы программы:
     *      1) Считайте с клавиатуры 4 целых числа.
     *      2) Выведите в консоль фразу "Количество отрицательных чисел: ХХХ, количество положительных чисел: ХХХ".
     * ХХХ - количество положительных и отрицательных чисел.
     * Число 0 - не положительное и не отрицательное, его при подсчете учитывать не нужно.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            int positiveNumber = 0;
            int negativeNumber = 0;

            for (int i = 0; i < 4; i++)
            {
                Console.Write($"Введите {i+1} число: ");
                int number = Convert.ToInt32(Console.ReadLine());

                if (number > 0) positiveNumber++;
                else if (number < 0) negativeNumber++;
            }

            Console.WriteLine($"Количество отрицательных чисел: {negativeNumber}, количество положительных чисел: {positiveNumber}");
        }
    }
}
