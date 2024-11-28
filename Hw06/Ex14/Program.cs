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
            int min = int.MaxValue;
            int minIndex = -1;

            int[] myArray = new int[10];
            int[] newArray = new int[10];

            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = 0; j < myArray.Length; j++)       
                {
                    if (myArray[j] < min)
                    {
                        min = myArray[j];
                        minIndex = j;
                    }
                }
                newArray[i] = min;

                myArray[minIndex] = int.MaxValue;
                min = int.MaxValue;
            }

            for (int i = 0; i < newArray.Length; i++)
            {
                Console.Write($"{newArray[i]}, ");
            }

        }
    }
}
