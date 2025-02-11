using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l10t18
{
    /*
     * Создайте метод MagicMovement(), который должен:
     *      1) Принимать строку в качестве входящего параметра.
     *      2) Если принятая строка содержит нечетное количество символов: возвращать строку которая содержит все символы принятой строки в обратном порядке.
     *      3) Если принятая строка содержит четное количество символов: возвращать строку, где четные и нечетные символы принятой строки поменяны местами.
     *      4) Если принята пустая строка: возвращать строку "Принята пустая строка".
     *      5) Если принято пустое значение: возвращать строку "Null и пустая строка не одно и тоже".
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string s = Console.ReadLine();

            Console.WriteLine(MagicMovement(s));

        }

        /* Добавьте свой код ниже */

        public static string MagicMovement(string s)
        {
            string returnString = "";
            if (s == "")
            {
                returnString = "Принята пустая строка";
            }
            else if (s == null)
            {
                returnString = "Null и пустая строка не одно и тоже";
            }
            else if (s.Length % 2 != 0)
            {
                Stack<char> symbols = new Stack<char>();
                for (int i = 0; i < s.Length; i++)
                {
                    symbols.Push(s[i]);
                }
                while (symbols.Count > 0)
                {
                    returnString += symbols.Pop();
                }
            }
            else if (s.Length % 2 == 0)
            {
                List<char> symbols = new List<char>();
                symbols.Add(' ');

                for (int i = 1; i <= s.Length; i++)
                {
                    symbols.Add(s[i - 1]);
                }

                for (int i = 1; i < symbols.Count; i++)
                {
                    returnString += symbols[i];
                }
            }

            return returnString;
        }
    }
}

