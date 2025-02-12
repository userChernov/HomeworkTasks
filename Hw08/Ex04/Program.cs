using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace l8t4
{
    /*
     * Внутри метода Main() отсортируйте коллекцию objectList в порядке возрастания.
     * Шаблон задачи изменять нельзя.
     */


    public class Program
    {
        public static List<object> objectList = new List<object>() { -1, 5.5, 6, 21.2, -21, 22.3, 6, 7, 23, 8, 2, 9, 2, 99, 101, -9, 5.7 };


        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */

            List<double> newList = new List<double>();

            foreach (object obj in objectList)
                newList.Add(Convert.ToDouble(obj));

            newList.Sort();
            objectList.Clear();

            foreach (object obj in newList)
                objectList.Add(obj);

            foreach (var item in objectList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
