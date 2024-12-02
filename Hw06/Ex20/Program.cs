using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l6t20
{
    /*
     * Измените шаблон таким образом, чтобы при выводе переменных в консоль количество цифр после запятой совпадало с числом в названии переменной, содержащей это число.
     * Остальные элементы шаблона изменять нельзя, округление при выводе допустимо.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            double d0 = 89 / 7d;
            double d1 = 89 / 17d;
            double d7 = 300 / 3d;
            double d5 = 54d / d0;

            Console.WriteLine(Double.Round(d0, 0));  //Измените меня!
            Console.WriteLine(Double.Round(d1, 1));  //Измените меня!
            Console.WriteLine("{0:0.0000000}", d7);  //Измените меня!
            Console.WriteLine(Double.Round(d5, 5));  //Измените меня!
        }
    }
}
