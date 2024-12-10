using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l6t17
{
    /*
     * Реализуйте метод GetArrayFromConsole(). Метод должен:
     *      1) Принимать число N в качестве входящего параметра.
     *      2) Создавать массив из N элементов и заполнять его строками, считанными с клавиатуры.
     *      3) Возвращать созданный массив строк из N элементов.
     * Если передано число N меньше 1, то размер возвращаемого массива должен быть равен 1.
     * Если передано число больше 10, то размер возвращаемого массива должен быть равен 10.
     * Внутри метода Main() выведите на экран информацию о массиве arr в следующем формате:
     *      1) "Количество элементов массива: ХХХ"
     *      2) "Минимальная длина элемента массива: ХХХ"
     *      3) "Максимальная длина элемента массива: ХХХ"
     * Выведите на экран 5 и 10 элемент массива. Шаблон задачи изменять нельзя.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            string[] arr = GetArrayFromConsole(101);
            /* Добавьте свой код ниже */

            int minElementLength = MinElementLength(arr);
            int maxElementLength = MaxElementLength(arr);

            Console.WriteLine($"Количество элементов массива: {arr.Length}");
            Console.WriteLine($"Минимальная длина элемента массива: {minElementLength}");
            Console.WriteLine($"Максимальная длина элемента массива: {maxElementLength}");

            Console.WriteLine($"Пятый элемент массива: {arr[4]}");
            Console.WriteLine($"Десятый элемент массива: {arr[9]}");


        }

        public static string[] GetArrayFromConsole(int x)
        {
            /* Добавьте свой код ниже */

            if (x < 1)
                x = 1;
            else if (x > 10)
                x = 10;

            string[] arr = new string[x];

            Console.WriteLine($"Создаем массив из {x} строк:");

            for (int i = 0; i < x; i++)
            {
                arr[i] = Console.ReadLine();
            }

            return arr;
        }

        public static int MinElementLength(string[] arr)
        {
            int elementLenth = int.MaxValue;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length < elementLenth)
                    elementLenth = arr[i].Length;
            }

            return elementLenth;
        }

        public static int MaxElementLength(string[] arr)
        {
            int elementLenth = int.MinValue;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length > elementLenth)
                    elementLenth = arr[i].Length;
            }

            return elementLenth;
        }

    }
}
