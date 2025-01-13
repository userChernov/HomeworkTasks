using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace l8t21
{
    /*
     * Создайте метод GetAllSum(), который принимает список массива целых чисел, а возвращает
     * произведение полных сумм всех его элементов.
     */


    public class Program
    {
        public static void Main(string[] args)
        {
            int[] arraySum1 = {1};
            int[] arraySum2 = {1, 2};
            int[] arraySum3 = {1, 2, 3};
            int[] arraySum4 = {1, 2, 3, 4};
            int[] arraySum5 = {1, 2, 3, 4, 5};
            int[] arraySum6 = {1, 2, 3, 4, 5, 6};
            int[] arraySum7 = {1, 2, 3, 4, 5, 6, 7};
            int[] arraySum8 = {1, 2, 3, 4, 5, 6, 7, 8};
            int[] arraySum9 = {1, 2, 3, 4, 5, 6, 7, 8, 9};

            Console.WriteLine(GetAllSum(arraySum1));
            Console.WriteLine(GetAllSum(arraySum2));
            Console.WriteLine(GetAllSum(arraySum3));
            Console.WriteLine(GetAllSum(arraySum4));
            Console.WriteLine(GetAllSum(arraySum5));
            Console.WriteLine(GetAllSum(arraySum6));
            Console.WriteLine(GetAllSum(arraySum7));
            Console.WriteLine(GetAllSum(arraySum8));
            Console.WriteLine(GetAllSum(arraySum9));
        }
        /* Добавьте свой код ниже */

        public static int GetAllSum(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
                sum += arr[i];

            return sum;
        }

    }
}
