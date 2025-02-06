using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace l9t19
{
    /*
     * Внутри метода Main() объявлена строка s, содержащая список слов, разделённых определённым символом.
     * Выведите на экран все слова из строки s, которые содержат в себе только цифры. Все найденные слова выведите
     * одной строкой через пробел. Шаблон задачи изменять нельзя.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            string s = "собачка;котик;123мишка;шишка;лента;123;кристал;полиморф;ксеноморф;шб;крапивка;игрушка;валенок;задача;123123123;красота;1;18й;5алучшевсех;17;квартал;999";
            /* Добавьте свой код ниже */

            List<string> splitted = s.Split(";").ToList();
            List<string> numbers = new List<string>();

            foreach (string word in splitted)
            {
                if (JustNumbers(word))
                    numbers.Add(word);
            }
            
            foreach (string word in numbers)
            {
                Console.WriteLine(word);
            }
        }

        public static bool JustNumbers(string s)
        {
            string asset = "0123456789";
            bool onlyNumbers = true;

            for (int i = 0; i < s.Length; i++)
            {
                if (!asset.Contains(s[i]))
                {
                    onlyNumbers = false;
                    break;
                }
            }

            return onlyNumbers;
        }
    }
}
