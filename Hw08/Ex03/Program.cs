using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace l8t3
{
    /*
   * Внутри метода Main() переведите все элементы коллекции objectList в элементы коллекции doubleList, используя цикл foreach.
   * Выведите на экран сумму всех элементов коллекции doubleList. Шаблон задачи изменять нельзя.
   */


    public class Program
    {
        public static ArrayList objectList = new ArrayList() { 1.3, 2.3, 3.3, -4.3, 5.3, -6.3, 7.3, 8.3, 9.3, 10, 6.3, 2.3, 3.6, 4.3, 1.3, 3.3, 73, -1.3, -9.3, 10 };
        public static List<double> doubleList = new List<double>();


        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */

            double sum = 0;

            foreach (object obj in objectList)
            {
                doubleList.Add(Convert.ToDouble(obj));
            }

            foreach (double element in doubleList)
            {
                sum += element;
            }

            Console.WriteLine(sum);
        }
    }
}

