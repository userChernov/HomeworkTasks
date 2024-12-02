using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex32
{
    /*
     * Создайте статический конструктор для класса Program, который должен выводить в консоль
     * число 8 в 10 степени, с использованием метода Pow() статического класса Math.
     */

    public class Program
    {
        /* Добавьте свой код ниже */
        static Program()
        {
            Console.WriteLine($"8^10 = {Math.Pow(8, 10)}");
        }

        public static void Main(string[] args)
        {
            Program testConsole = new Program();
        }
    }
}
