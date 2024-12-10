using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l6t19
{
    /*
     * Реализуйте статический метод WordSorter() который:
     *      1) Принимает строку произвольной длины.
     *      2) Формирует и возвращает новую строку так, чтобы буквы каждого слова принятой строки были отсортированы по алфавиту.
     *      3) Если слово содержит буквы не русского алфавита или цифры - оно должно остаться без изменения.
     * Шаблон задачи изменять нельзя.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            string s1 = "Красивая строка с1223 123";
            string s2 = "Один два три";
            string s3 = "Арбу3";

            WordSorter(s1);
            WordSorter(s2);
            WordSorter(s3);

            Console.WriteLine(WordSorter(s1));
            Console.WriteLine(WordSorter(s2));
            Console.WriteLine(WordSorter(s3));
        }

        public static string WordSorter(string word)
        {
            /* Добавьте свой код ниже */
            string[] arrayString = word.Split(' ');
            string sortString = "";
            bool needSort = true;

            string buffer = "";

            for (int i = 0; i < arrayString.Length; i++)
            {
                buffer = arrayString[i];

                for (int k = 0; k< buffer.Length; k++)
                {
                    if (buffer[k] >= 'А' && buffer[k] <= 'я' || buffer[k] == 'ё' || buffer[k] =='Ё')
                    {
                    }
                    else 
                        needSort = false;
                }

                char[] arrayChar = buffer.ToArray();

                if (needSort)
                {
                    Array.Sort(arrayChar);
                    buffer = "";

                    for (int l = 0; l < arrayChar.Length; l++)
                    {
                       buffer += arrayChar[l];
                    }
                }

                sortString += buffer;
                sortString += " ";

            }

            return sortString;
            
        }
    }
}
