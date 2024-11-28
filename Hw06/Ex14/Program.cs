using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l6t14
{
    /*
     * Внутри метода Main() создайте массив из 10 целых чисел и сохраните его в соответствующую переменную.
     * Считайте с клавиатуры 10 чисел и добавьте их в массив. Отсортируйте полученный массив в порядке возрастания
     * и выведите его на экран, каждый элемент массива с новой строки. Методом Sort пользоваться нельзя.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */

            //Console.Clear();

            int temp;
            int minIndex = -1;

            int[] myArray = new int[10];
            for (int i = 0; i < myArray.Length; i++)
                myArray[i] = int.Parse(Console.ReadLine());
            

            for (int i = 0; i < myArray.Length; i++)
            {
                minIndex = GetMinIndex(i, myArray);

                temp = myArray[i];
                myArray[i] = myArray[minIndex];
                myArray[minIndex] = temp;
            }

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"{myArray[i]}, ");
            }

        }

        public static int GetMinIndex(int index, int[] array)
        {
            //Console.WriteLine("=============STARTED GETMININDEX=========");

            //Console.WriteLine("array:");
            // for (int i = 0; i < array.Length; i++)
            // {
            //     Console.Write($"{array[i]}, ");
            // }
            //Console.WriteLine();

            int minIndex = -1;
            int min = int.MaxValue;

            for (int i = index; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    minIndex = i;
                    min = array[i];
                }
            }

            // Console.WriteLine($"minIndex = {minIndex}");
            // Console.WriteLine($"minValue = {array[minIndex]}");

            // Console.WriteLine("=============FINISH GETMININDEX=========");
            return minIndex;
        }
    }
}
