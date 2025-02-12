using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l9t22
{
    /*
     * Внутри метода Main() дана строка s. Необходимо программно:
     *      1) Заменить все символы 1 на буквы o.
     *      2) Заменить все символы 2 на буквы и.
     *      3) Заменить все символы 3 на буквы к.
     * Шаблон задачи изменять нельзя.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            string s = "31т232 – 31т232 – 31т232 бегем1т232!";
            /* Добавьте свой код ниже */
            List<char> data = s.ToList();
            List<char> correctData = new List<char>();

            foreach (char c in data)
            {
                if (c == '1')
                {
                    correctData.Add('о');
                    continue;
                }
                else if (c == '2')
                {
                    correctData.Add('и');
                    continue;
                }
                else if (c == '3')
                {
                    correctData.Add('к');
                    continue;
                }

                correctData.Add(c);
            }

            s = "";

            foreach (char c in correctData)
            {
                s += c;
            }

            Console.WriteLine(s);
        }
    }
}
