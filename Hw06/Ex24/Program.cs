using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l6t24
{
    /*
     * Внутри метода Main() найдите суммы всех элементов двумерного массива arr находящихся в одном столбце и выведите их на экран в одну строку через пробел.
     * Шаблон задачи изменять нельзя.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            int[][] arr = new int[5][];
            arr[0] = new int[] { 1, 52, 6, -17, 57 };
            arr[1] = new int[] { 11, -50, 67, -17, -178 };
            arr[2] = new int[] { -18, -5, 6, 20, 30 };
            arr[3] = new int[] { 2, 5, -76, 78, 83 };
            arr[4] = new int[] { 11, 5, 4, -57, 15 };
            /* Добавьте свой код ниже */

            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                    sum += arr[j][i];
                    
                Console.Write($"{sum} ");
                sum = 0;
            }
            Console.WriteLine();
        }
    }
}
