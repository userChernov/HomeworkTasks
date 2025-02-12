using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l9t15
{
    /*
     * Внутри метода Main() считайте с клавиатуры текстовую строку, после чего выведите на экран две строки:
     *      1) Первая содержит только гласные буквы из введенной строки.
     *      2) Вторая содержит только согласные буквы и знаки препинания из введённой строки.
     * Символы в первой и второй строке должны быть выведены через пробел.
     * =====================================================================================================
     *      Учитывается только русский алфавит. Регистр букв имеет значение!
     *      К знакам препинания в том числе относятся следующие символы: ! ( ) ? " -
     * =====================================================================================================
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */

            Console.WriteLine("Введите текстовую строку:");
            string s = Console.ReadLine();

            if (s == "")
                throw new Exception("Введена пустая строка");

            Console.WriteLine(DivideVowel(s));
            Console.WriteLine(DivideConsonant(s));

        }

        public static string DivideVowel(string s)
        {
            string vowel = "ауоиэыяюеё";

            string result = "";

            for (int i = 0; i < s.Length; i++)
            {
                char symbol = char.ToLower(s[i]);

                if (vowel.Contains(symbol))
                {
                    result += s[i];
                    result += ' ';
                }
            }

            return result;
        }
        
        public static string DivideConsonant(string s)
        {
            string consonant = "бвгджзйклмнпрстфхцчшщ.,;!()?-\"";
            string result = "";

            for (int i = 0; i < s.Length; i++)
            {
                char symbol = char.ToLower(s[i]);

                if (consonant.Contains(symbol))
                {
                    result += s[i];
                    result += ' ';
                }
            }

            return result;
        }
    }
}
