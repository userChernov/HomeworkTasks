using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l7t4
{
    /*
     * В методе Main() удалите из динамического массива arrayList все повторяющиеся элементы, после чего 
     * отсортируйте массив в порядке возрастания и дополните его недостающими элементами так, чтобы получилось
     * непрерывно возрастающее на единицу множество от минимального до максимального элемента массива.
     * Шаблон задачи изменять нельзя.
     */

    public class Program
    {
        public static ArrayList arrayList = new ArrayList() { 1, 5, 6, 7, 6, 8, 9, 10, 2, 5, 7, 9, 15 };

        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */

            bool isEqual = false;

            int i = 0;
            while (i < arrayList.Count)
            {
                for (int j = i + 1 ; j< arrayList.Count; j++)
                {
                    if ( Equals(arrayList[i], arrayList[j]) )
                    {
                        isEqual = true;
                        arrayList.RemoveAt(j);
                    }    
                }
                
                if (isEqual)
                {
                    arrayList.RemoveAt(i);
                    isEqual = false;
                }
                else
                    i++;
            }

            arrayList.Sort();

            i = Convert.ToInt32(arrayList[0]) + 1;
            int max = Convert.ToInt32(arrayList[arrayList.Count - 1]);

            while ( i < max ) 
            {
                if (!arrayList.Contains(i))
                    arrayList.Add(i);
                i++;
            }

            arrayList.Sort();

            for (int j = 0; j < arrayList.Count; j++)
            {
                Console.WriteLine(arrayList[j]);
            }
        }
    }
}