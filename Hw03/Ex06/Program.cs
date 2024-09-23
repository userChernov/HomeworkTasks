using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6
{
    /*
     * Закомментируйте правильные строчки, чтобы в консоль была выведена фраза "Результат: 7" в одну строку.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            int a = 9;
            //a = 7;
            int b = 5;
            //int c = 123;
            a = b - 8;
            int result = -19;
            //result = c + a + b;
            result = a + b + b;
            //result = a + a + a;
            Console.WriteLine("Результат: " + result);
        }
    }
}