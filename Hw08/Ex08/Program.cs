using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace l8t8
{
    /*
     * Внутри метода Main() удалите из коллекции setA все элементы, которые содержатся в коллекции listB.
     * Использовать циклы и условные конструкции нельзя. Шаблон задачи изменять нельзя.
     */


    public class Program
    {
        public static HashSet<int> setA = new HashSet<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 };
        public static List<int> listB = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */

            setA.ExceptWith(listB);

            foreach (var a in setA)
            {
                Console.WriteLine(a);
            }
        }
    }
}
