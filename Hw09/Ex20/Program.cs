using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l9t20
{
    /*
     * Внутри метода Main() объявлена строка s, содержащая список слов, разделённых определённым символом.
     * Выведите на экран все слова из строки s, которые содержат в себе и цифры, и буквы, каждое с новой строки.
     * Шаблон задачи изменять нельзя.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            string s = "собачка;котик;123мишка;шишка;лента;123;кристал;полиморф;ксеноморф;шб;крапивка;игрушка;валенок;задача;123123123;красота;1;18й;5алучшевсех;17;квартал;999";
            /* Добавьте свой код ниже */

            List<string> splitted = s.Split(";").ToList();
            List<string> correct = new List<string>();

            foreach (string word in splitted)
            {
                if (IsCorrect(word))
                    correct.Add(word);
            }
            
            foreach (string word in correct)
            {
                Console.WriteLine(word);
            }
        }

        public static bool IsCorrect(string s)
        {
            string assetNumber = "0123456789";
            string assetLetters = "абвгдеёжзийклмнопрстуфхцчшщъыьэюяabcdefghijklmnopqrstuvwxyz";
            bool istNumber = false;
            bool isLetters = false;

            for (int i = 0; i < s.Length; i++)
            {
                char a = Char.ToLower(s[i]);
                if (assetNumber.Contains(a) && !istNumber)
                {
                    istNumber = true;
                }
                if (assetLetters.Contains(a) && !isLetters)
                {
                    isLetters = true;
                }
            }

            if (istNumber && isLetters)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}