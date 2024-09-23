using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7
{
    /*
     * Внутри метода Main() объявлены четыре строковые переменные: s1,s2,s3,s4. 
     * Выведите значения переменных в консоль, каждое с новой строки, но используя лишь 1 вызов метода Console.Write()
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            string s1 = "Иногда существенно проще";
            string s2 = "загуглить";
            string s3 = "или посмотреть в документации";
            string s4 = "чем пытаться изобрести велосипед...";

            Console.Write($"{s1}\n{s2}\n{s3}\n{s4}");

            /* Добавьте свой код ниже */
        }
    }
}