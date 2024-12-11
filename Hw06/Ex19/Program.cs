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
                    Array.Sort(arrayChar, (symbol1, symbol2) => char.ToLower(symbol1).CompareTo(char.ToLower(symbol2)));
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



// using System;
// using System.Text;

// namespace l6t19
// {
//     public class Program
//     {
//         public static void Main(string[] args)
//         {
//             string s1 = "Красивая строка с1223 123";
//             string s2 = "Один два три";
//             string s3 = "Арбу3";
//             Console.WriteLine(WordSorter(s1));
//             Console.WriteLine(WordSorter(s2));
//             Console.WriteLine(WordSorter(s3));
//         }

//         public static string WordSorter(string input)
//         {
//             string[] words = input.Split(' ');
//             char[][] charArrays = new char[words.Length][];

//             for (int i = 0; i < words.Length; i++)
//             {
//                 charArrays[i] = words[i].ToCharArray();
//             }
            
//             for (int i = 0; i < charArrays.Length; i++)
//             {
//                 if (IsRussianWord(charArrays[i]))
//                 {
//                     Array.Sort(charArrays[i], (symbol1, symbol2) => char.ToLower(symbol1).CompareTo(char.ToLower(symbol2)));
//                 }
//             }

//             for (int i = 0; i < words.Length; i++)
//             {
//                 words[i] = new string(charArrays[i]);
//             }

//             string result = string.Join(" ", words);

//             return result;
//         }

//         private static bool IsRussianWord(char[] wordChars)
//         {
//             foreach (char c in wordChars)
//             {
//                 bool isRussianLetter = (c >= 'А' && c <= 'Я') || (c >= 'а' && c <= 'я') || c == 'ё' || c == 'Ё';
//                 if (!isRussianLetter)
//                 {
//                     return false;
//                 }
//             }
//             return true;
//         }
//     }
// }