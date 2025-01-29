using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace l9t13
{
    /*
     * Внутри метода Main() для каждого элемента в списке dateStrings извлеките значения даты
     * и выведите их на экран в следующем формате: "день-=-месяц-=-год".
     * Шаблон задачи изменять нельзя.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> dateStrings = new List<string>() { "11.11.2011", "11.10.2001", "12.12.2012", "01.01.3000", "31.12.2019" };
            /* Добавьте свой код ниже */

            foreach (var element in dateStrings)
            {
                ConvertAndPrint(element);
            }
        }

        public static void ConvertAndPrint(string s)
        {
            string newS = "";

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != '.')
                    newS += s[i];
                else
                    newS += "-=-";
            }

            Console.WriteLine(newS);
        }
    }
}
