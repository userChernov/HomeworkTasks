using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l6t10
{
    /*
     * Измените шаблон таким образом, чтобы безопасно парсить число из строки, используя метод TryParse структуры Int32.
     * Если введено число - выведите его на экран, в противном случае выведите на экран фразу "Ошибка парсинга!".
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int a;
            bool isInt = Int32.TryParse(s, out a);

            if (isInt)
                Console.WriteLine(a);
            else
                Console.WriteLine("Ошибка парсинга!");
        }
    }
}
