using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    /* 
     * Внутри метода Main() необходимо добавить вывод в консоль сумму всех переменных 
     * (a,b,c,d,e) с добавлением фразы: "Сумма всех значений равна: ХХХ", 
     * где ХХХ - это сумма всех переменных класса.
     */

    class Program
    {
        static int a = 5;
        static int b = 7, c = 10;
        static int d = 82;
        static int e = 17;
        public static void Main(string[] args)
        {
            Console.WriteLine($"Сумма всех значений равна: {a + b + c + d + e}");
        }
    }
}