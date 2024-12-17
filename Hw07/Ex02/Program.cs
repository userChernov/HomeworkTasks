using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l7t2
{
    /*
     * Внутри метода Main() заполните динамический массив arr, поместив в него все четные числа от 0 до 100 включительно, после чего выведите их в консоль одной строкой,
     * разделив каждый элемент символом "-".
     */

    public class Program
    {
        public static ArrayList arr = new ArrayList();

        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */

            for (int i  = 0; i  < 101; i += 2)
            {
                arr.Add(i);
            }

            foreach (object obj in arr)
                Console.Write($"{obj}-");

            Console.WriteLine();

            for (int i = 0; i < arr.Count; i++)
                Console.Write($"{arr[i]}-");
                
        }
    }
}

