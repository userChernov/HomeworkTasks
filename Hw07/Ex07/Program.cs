using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l7t7
{
    /*
     * Внутри метода Main() объявлен список list из 10 строк. У этого списка необходимо:
     *      1) Удалить последний элемент списка и переместить его в начало.
     *      2) Повторить операцию перестановки суммарно 17 раз.
     * Вывести на экран все элементы списка  list после преобразования, каждое значение с новой строки.
     * Шаблон задачи изменять нельзя.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> list = new List<string>() { "строка1", "строка21", "строка31", "строка41", "строка51", "строка61", "строка71", "строка81", "строка91", "строка101" };
            /* Добавьте свой код ниже */

            for (int i = 0; i < 17; i++)
            {
                list.Insert(0, list[list.Count - 1]);
                list.RemoveAt(list.Count - 1);
            }

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}
