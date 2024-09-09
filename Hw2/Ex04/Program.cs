using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04
{
    /*
     * Задайте переменной x такое значение, чтобы в результате в консоль было выведено 100.
     */

    public class Program
    {
        static int x;

        public static void Main(string[] args)
        {
            int a = 17;
            int b = 99;
            x = 100 - a - b;
            Console.WriteLine(a + b + x);
        }
    }
}
