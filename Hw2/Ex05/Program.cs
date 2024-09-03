using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05
{
    /*
     * Внутри метода Main() выведите в консоль значения переменных b и s в следующем формате:
     * "Значение переменной b = XXX, а значение переменной s = YYY!", 
     * где XXX и YYY - значения соответствующих переменных.
     * 
     * P.S. Не забудьте про пробелы и знаки препинания =)
     */

    public class Program
    {
        static int b;
        static string s;

        public static void Main(string[] args)
        {
            Console.WriteLine($"Значенте переменной b = {b}, а значение переменной s = {s}!");
            Console.Write("Значение переменной b = ");
            Console.Write(b);
            Console.Write(", а значение переменной s = ");
            Console.Write(s);
            Console.WriteLine("!");
        }
    }
}
