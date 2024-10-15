using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex24
{
    /*
     Выведите в консоль таблицу умножения 10 на 10. Каждое число в строке разделите пробелом.
     */
    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write($"{i * j} ");
                }

                Console.WriteLine();
            }


        }
    }
}
