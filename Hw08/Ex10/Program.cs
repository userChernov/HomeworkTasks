using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l8t10
{
    /*
     * Создайте статический метод GetCharDictionary(), который:
     *      1) Принимает строку в качестве входящего параметра.
     *      2) Возвращает словарь, где ключи - все символы принятой строки, а значения - количество повторений данных символов.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Dictionary<char, int> myTestDictionary = new Dictionary<char, int>();

            string word = Console.ReadLine();

            myTestDictionary = GetCharDictionary(word);

            foreach (var item in myTestDictionary)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }

        }

        public static Dictionary<char, int> GetCharDictionary(string data)
        {
            Dictionary<char, int> charInt = new Dictionary<char, int>();

            for (int i = 0; i < data.Length; i++)
            {
                char symbol = data[i];
                int counts = 1;

                if (charInt.ContainsKey(symbol))
                    continue;

                for (int j = i + 1; j < data.Length; j++)
                {
                    if (data[j] == symbol)
                        counts ++;
                }
                
                charInt.Add(symbol, counts);
            }

            return charInt;
        }
    }
}
