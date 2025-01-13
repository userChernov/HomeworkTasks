using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l6t23
{
    /*
     * Задан динамический массив arr, известно, что внутри массива arr имеются: строки, целые и дробные числа, логические значения.
     * Внутри метода Main() реализуйте следующую логику:
     *      1) Создайте 4 типизированных списка, в соответствии с возможными типами внутри динамического массива arr.
     *      2) Рассортируйте все элементы массива arr по соответствующим спискам в зависимости от типа элемента.
     *      3) Выведите на экран информацию о получившихся списках в следующем формате:
     * "Список целых чисел включает в себя ХХХ элементов.", где ХХХ - количество элементов соответствующего типа.
     * "Список строк включает в себя ХХХ элементов.", где ХХХ - количество элементов соответствующего типа.
     * "Список дробных чисел включает в себя ХХХ элементов.", где ХХХ - количество элементов соответствующего типа.
     * "Список логических значений включает в себя ХХХ элементов.", где ХХХ - количество элементов соответствующего типа.
     * Последней строкой выведите на экран общее количество элементов, которые содержались в динамическом массиве arr.
     * Шаблон задачи изменять нельзя.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            ArrayList arr = new ArrayList() { "ч", 1, 2, 3, "q", true, false, "й", 1.11, 2.2, 1d, 2d, 17, 17.0, 123, "int32", false, true };
            /* Добавьте свой код ниже */

            List<int> intList = new List<int>();
            List<string> stringList = new List<string>();
            List<double> doubleList = new List<double>();
            List<bool> boolList = new List<bool>();

            foreach (object obj in arr)
            {
                if (obj is int)
                    intList.Add(Convert.ToInt32(obj));
                else if (obj is string)
                    stringList.Add(Convert.ToString(obj));
                else if (obj is double)
                    doubleList.Add(Convert.ToDouble(obj));            
                else if (obj is bool)
                    boolList.Add(Convert.ToBoolean(obj));
            }

            Console.WriteLine($"Список целых чисел включает в себя {intList.Count} элементов.");
            Console.WriteLine($"Список строк включает в себя {stringList.Count} элементов.");
            Console.WriteLine($"Список дробных чисел включает в себя {doubleList.Count} элементов.");
            Console.WriteLine($"Список логических значений включает в себя {boolList.Count} элементов.");
        }
    }
}