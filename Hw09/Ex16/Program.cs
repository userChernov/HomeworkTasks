using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l9t16
{
    /*
     * Внутри метода Main() создайте список, который может содержать массив целых чисел. Добавьте в список 5 массивов длинной:
     *      1) 0.
     *      2) 7.
     *      3) 12.
     *      4) 8.
     *      5) 17.
     * Заполните эти массивы случайными числами и выведите значения всех элементов списка, каждое с новой строки.
     * При выводе элементов каждого из массивов списка, они должны выводиться в одну строку, разделенные пробелом. 
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Console.Clear();

            List<int[]> myList = new List<int[]>();
            List<int> taskCondition = new List<int>() {0, 7, 12, 8, 17};
            Random rand = new Random();

            for (int i = 0; i < taskCondition.Count; i++)
            {
                int[] arr = new int[taskCondition[i]];

                for (int j = 0; j < arr.Length; j++)
                    arr[j] = rand.Next();

                myList.Add(arr);
            }

            for (int i = 0; i < myList.Count; i++)
            {
                for (int j = 0; j < myList[i].Length; j++)
                {
                    Console.Write(myList[i][j]);
                    if (j == myList[i].Length - 1)
                        continue;
                    
                    Console.Write(" ");
                }

                Console.WriteLine();
                
            }

        }
    }
}
