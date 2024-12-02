using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex23
{
    /*
     * Выведите в консоль квадрат 10 на 10, который состоит только из букв Ъ.
     * Для решения используйте цикл while.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            int line = 0;
            int column = 0;

            while (column < 10)
            {
                while (line < 10)
                {
                    Console.Write("ъ");
                    line++;
                }

                Console.WriteLine();
                line = 0;
                column++;
            }
        }
    }
}
