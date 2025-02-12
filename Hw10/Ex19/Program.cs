using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l10t19
{
    /*
     * Создайте метод IsVowel(), который должен:
     *      1) Принимать символ в качестве входящего параметра.
     *      2) Возвращать true, если принятый символ гласный и относится к русскому алфавиту.
     *      3) Возвращать false во всех остальных случаях.
     * P.S. Регистр тоже учитывается!
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите символ: ");
            char symbol = Char.Parse(Console.ReadLine());

            bool vowel = IsVowel(symbol);

            if (vowel)
                Console.WriteLine("Это гласнаая буква русского алфавита");
            else
                Console.WriteLine("Это какой-то другой символ, но точно не гласная букваа русского алфавита");
        }

        /* Добавьте свой код ниже */
        public static bool IsVowel(char symbol)
        {
            bool result = false;;

            string data = "уеёыаоэяию";

            if (data.Contains(Char.ToLower(symbol)))
                result = true;

            return result;
        }
    }
}

