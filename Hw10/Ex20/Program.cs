using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l10t20
{
    /*
     * Реализуйте метод MagicReverse(), который:
     *      1) Должен возвращать принятую строку, записанную в обратном порядке, если строка заканчивается гласной буквой.
     *      2) Должен возвращать принятую строку, записанную символами с обратными регистром, если строка заканчивается согласной буквой.
     *      3) Если строка не заканчивается буквой, то она должна быть возвращена без изменения.
     * Шаблон задачи изменять нельзя.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(MagicReverse("Красота"));
            Console.WriteLine(MagicReverse("КоТ"));
            Console.WriteLine(MagicReverse("Победа!"));
            Console.WriteLine(MagicReverse("ЗаМоК"));
            Console.WriteLine(MagicReverse("Яизенма"));
        }

        public static string MagicReverse(string s)
        {
            /* Добавьте свой код ниже */

            char lastSymbol = s[s.Length - 1];
            string data = "ауоиэыяюеё";
            string result = "";

            if (!Char.IsLetter(lastSymbol))
            {
                return s;
            }
            else if (data.Contains(Char.ToLower(lastSymbol)))
            {
                Stack<char> rotate = new Stack<char>();
                for (int i = 0; i < s.Length; i++)
                    rotate.Push(s[i]);

                while (rotate.Count > 0)
                    result += rotate.Pop();
            }
            else
            {
                for (int i = 0; i < s.Length; i++)
                {
                    if (Char.IsLower(s[i]))
                        result += Char.ToUpper(s[i]);
                    else
                        result += Char.ToLower(s[i]);
                }
            }

            return result;
        }
    }
}

