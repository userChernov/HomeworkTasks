using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace l8t6
{
    /*
     * Внутри метода Main() объедините 2 коллекции - listA и listB, результат объединения поместите в третью коллекцию listX.
     * Сначала должны идти элементы коллекции listB, а затем коллекции listA. Коллекция listX не должна содержать элементов,
     * которые одновременно присутствуют в обеих исходных коллекциях. Шаблон задачи изменять нельзя.
     */


    public class Program
    {
        public static List<int> listA = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
        public static List<double> listB = new List<double>() { 1, 2.2, 3.0, 4.4, 5, 6, 9.1, 10.2, 11.2, 3, 10.1, 10.2 };
        public static List<float> listX = new List<float>() { };


        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */

            List<double> listTemp = new List<double>();

            for (int i = 0; i < listA.Count; i++)
                listTemp.Add(listA[i]);

            for (int i = 0; i < listB.Count; i++)
            {
                if ( listTemp.Contains( listB[i] ) )
                    continue;

                listX.Add( (float)listB[i]) ;
            }

            for (int i = 0; i < listTemp.Count; i++)
            {
                if ( listB.Contains( listTemp[i] ) )
                    continue;

                listX.Add( Convert.ToSingle(listTemp[i]) );
            }

            for (int i = 0; i < listX.Count; i++)
                Console.Write($"{listX[i]}, ");
        }
    }
}
