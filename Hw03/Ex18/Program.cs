using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex18
{
    /*
     * Добавьте в класс Program статический метод MirrorTriplePrinter(), который 3 раза выводит 
     * в консоль фразу, введенную с клавиатуры, каждую с новой строки. 
     * Тип возвращаемого значения метода MirrorTriplePrinter() сделайте пустым.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            //string text = Console.ReadLine();
            //MirrorTriplePrinter(text);
            
            MirrorTriplePrinter();
        }

        static void MirrorTriplePrinter()
        {
            string message = Console.ReadLine();
            Console.WriteLine(message);
            Console.WriteLine(message);
            Console.WriteLine(message);
        }

        /*
        static void MirrorTriplePrinter(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine(message);
            Console.WriteLine(message);
        }
        */
   }
}