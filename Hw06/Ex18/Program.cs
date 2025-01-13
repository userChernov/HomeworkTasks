using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l6t18
{
    /*
     * Внутри метода Main() найдите все элементы массива arr, значения которых находятся +\-2 от среднего арифметического всех элементов массива.
     * Найденные значения поместите в отдельный массив и выведите все его элементы в консоль, каждый элемент с новой строки.
     * Шаблон задачи изменять нельзя.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            double[] arr = { 1.22, 1.7, 7.8, 2.4, 8, 2.3, 2.5, 2.6, 6, 17, 7, 8, 12, 1, 11, 12, 5, 7.2 };
            /* Добавьте свой код ниже */

            double arithmetic = CalcArithmetic(arr);
            int arrayElementCoutnt = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < arithmetic + 2 && arr[i] > arithmetic - 2)
                    arrayElementCoutnt ++;
            }

            double[] newArr = new double[arrayElementCoutnt];
            int newArrIndex = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < arithmetic + 2 && arr[i] > arithmetic - 2)
                {
                    newArr[newArrIndex] = arr[i];
                    newArrIndex++;
                }
            }

            for (int i = 0; i < newArr.Length; i++)
            {
                Console.WriteLine(newArr[i]);
            }
        }

        public static double CalcArithmetic(double[] array)
        {
            double arithmetic = 0;

            for (int i = 0; i < array.Length; i++)
            {
                arithmetic += array[i];
            }

            Console.WriteLine($"Arithmetics = {arithmetic / array.Length}");
            return arithmetic / array.Length;
        }
    }
}
