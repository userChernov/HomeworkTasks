using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex17
{
    /*
     * Добавьте в класс Program статический метод TriplePrinter(), который 3 раза выводит 
     * в консоль фразу "Просто не значит не правильно", каждую с новой строки. 
     * Тип возвращаемого значения метода TriplePrinter() сделайте пустым.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            TriplePrinter();
        }

        static void TriplePrinter()
        {
            Console.WriteLine("Просто не значит правильно");
            Console.WriteLine("Просто не значит правильно");
            Console.WriteLine("Просто не значит правильно");
        }
    }
}