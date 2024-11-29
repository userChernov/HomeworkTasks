using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l6t16
{
    /*
     * Внутри метода Main() объявлен массив arr из 20 чисел. В методе Main() созданы еще два массива целых чисел, каждый размером на 10 чисел.
     * Разделите исходный массив arr на два массива: половину чисел добавьте в первый созданный массив, вторую половину во второй.
     * Выведите на экран содержимое двух созданных массивов, каждый с новой строки. Все элементы массива должны выводится одной строкой
     * разделённые пробелом. Шаблон задачи изменять нельзя.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            int[] arr1 = new int[10];
            int[] arr2 = new int[10];
            /* Добавьте свой код ниже */
            int halfLengtth = arr.Length / 2;

            for (int i = 0; i < halfLengtth; i++)
                arr1[i] = arr[i];
            
            for (int i = halfLengtth; i < arr.Length; i++)
                arr2[i - halfLengtth] = arr[i];

            for (int i = 0; i < arr1.Length - 1; i++)
                Console.Write($"{arr1[i]}, ");
            Console.WriteLine($"{arr1[arr1.Length - 1]}");

            for (int i = 0 ; i < arr2.Length - 1; i++)
                Console.Write($"{arr2[i]}, ");
            Console.WriteLine($"{arr2[arr2.Length - 1]}");

        }
    }
}
