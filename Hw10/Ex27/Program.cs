using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l10t27
{
    /*
     * Внутри класса Program создайте и реализуйте метод Decrypt(), который будет отвечать за дешифрование строк по методу Цезаря.
     * Метод Decrypt() должен:
     *      1) Принимать в качестве входящего параметра:
     *        - строку, подлежащую дешифрованию;
     *        - целое положительное число, отвечающее за шаг сдвига;
     *        - логический параметр, отвечающий за направление сдвига (true - положительное, false - отрицательное).
     *      2) Возвращать дешифрованную строку по методу Цезаря, с учетом следующих особенностей шифрования:
     *        - сдвигу подвергались только символы русского алфавита;
     *        - пробелы, знаки препинаний и иностранные символы не изменялись.
     * Шаблон задачи изменять нельзя.
     * P.S. Не забудьте, что в русском алфавите 33 буквы, но индекс первой буквы следует начинать с нуля!
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Decrypt("Г хю шсусы!", 3, true));
            Console.WriteLine(Decrypt("А ты хорошо подумал?", 3, false));
            Console.WriteLine(Decrypt("To be, or not to be - жуч ж ьйс жуфхуц...", 5, true));
        }

        /* Добавьте свой код ниже */

        public static string Decrypt(string s, int count, bool isForward)
        {
            string result = "";
            string alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";

            if (isForward)
                count = -count;

            for (int i = 0; i < s.Length; i++)
            {
                char symbol = Char.ToLower(s[i]);

                if (!alphabet.Contains(symbol))
                {
                    result += s[i];
                    continue;
                }
                    
                int alphabetNumber = alphabet.IndexOf(symbol) + count;

                if (alphabetNumber < 0)
                    alphabetNumber += alphabet.Length;
                else if (alphabetNumber > alphabet.Length)
                    alphabetNumber -= alphabet.Length;

                if (Char.IsUpper(s[i]))
                    result += Char.ToUpper(alphabet[alphabetNumber]);
                else
                    result += alphabet[alphabetNumber];
            }

            return result;
        }

    }
}

