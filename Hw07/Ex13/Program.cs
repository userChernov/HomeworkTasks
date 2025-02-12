using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace l7t13
{
    /*
     * Реализуйте метод MyOwnSortMethod(), который должен принимать список целых чисел, а возвращать
     * их в виде списка целых чисел, отсортированного в порядке убывания. Методом Sort пользоваться нельзя.
     * Шаблон задачи изменять нельзя.  
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> originalList = new List<int>() { 12, 23, 123, 123, 545, 23, 12, 434567, 79, 89, 678, 56, 345, 233, 1290, 78, 567, 345, 12, 23, 577658, 987 };
            List<int> sortedList = MyOwnSortMethod(originalList);
            foreach (var item in sortedList)
            {
                Console.WriteLine(item);
            }
        }

        private static List<int> MyOwnSortMethod(List<int> p)
        {
            /* Добавьте свой код ниже */
            int i = 0;
            while (i + 1 < p.Count)
            {
                if (p[i] < p[i + 1])
                {
                    int bufer = p[i];
                    p.RemoveAt(i);
                    p.Insert(i + 1, bufer);

                    i = 0;
                }
                else
                    i++;
            }

            return p;
        }
    }
}

