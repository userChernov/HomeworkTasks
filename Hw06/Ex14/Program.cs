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

            int temp;
            int minIndex;

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
            int minIndex = index;
            int min = array[index];

            for (int i = index + 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    minIndex = i;
                    min = array[i];
                }
            }

            return minIndex;
        }
    }
}
