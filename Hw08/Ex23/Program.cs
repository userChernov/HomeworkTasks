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
            Dictionary<string, int> elements = new Dictionary<string, int>();
            int maxCount = 0;
            string maxLetter = "";
            int index = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (elements.ContainsKey(arr[i]))
                    elements[arr[i]]++;
                else
                    elements[arr[i]] = 1;
            }

            foreach (KeyValuePair<string, int> letter in elements)
            {
                if (letter.Value > maxCount)
                {
                    maxCount = letter.Value;
                    maxLetter = letter.Key;
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == maxLetter)
                {
                    index = i;
                    break;
                }
            }

            return index;
        }


    }

}

