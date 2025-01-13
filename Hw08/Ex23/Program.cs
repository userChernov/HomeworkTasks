using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace l8t23
{
    /*
     * Создайте статический метод GetMostCommonElement(), который должен принимать массив строк и возвращать
     * наиболее часто встречающийся элемент массива. Если таких элементов несколько - выведите тот, 
     * который имееет наименьший индекс первого элемента. Внутри метода Main() выведите на экран результат 
     * вызова метода GetMostCommonElement(), передав значение входящего параметра метода Main() в качестве аргумента.
     */


    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */

            string[] arr = {"a", "b", "c", "d", "e", "c", "d", "e", "b", "e"};

            Console.WriteLine($"element = {arr[GetMostCommonElement(arr)]}, first index = {GetMostCommonElement(arr)}");

        }
        /* Добавьте свой код ниже */

        public static int GetMostCommonElement(string[] arr)
        {
            int maxCount = 0;
            int index = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                ElementCount(i, arr, out int count, out int firstIndex);

                if (count > maxCount)
                {
                    maxCount = count;
                    index = firstIndex;
                }
            }

            return index;
        }

        private static void ElementCount(int thisIndex, string[] arr, out int count, out int firstIndex)
        {
            count = 0;
            firstIndex = 0;

            for (int i = thisIndex + 1; i < arr.Length; i++)
            {
                if (arr[i] == arr[thisIndex])
                {
                    count += 1;

                    if (firstIndex == 0)
                        firstIndex = thisIndex;
                }
            }
        }
    }
}

