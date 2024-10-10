using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03
{
    /*
     * Добавьте в класс Program статический метод UniversalPrinter(), 
     * который выводит на экран переданную строку такое количество раз, которое передается ему в качестве параметра. 
     * Каждый вывод с новой строки. Внутри метода Main() вызовите метод UniversalPrinter(), 
     * передав ему строку "Красота" и число 5 в качестве аргументов.
     */
    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            UniversalPrinter("Красота", 5);
            
        }
        /* Добавьте свой код ниже */

        public static void UniversalPrinter(string message, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(message);
            }
        }
    }
}
