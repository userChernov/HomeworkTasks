using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex21
{
    /*
     * Добавьте в класс Program статический метод Twice(), который принимает один 
     * строковый параметр, а выводит на экран переданный параметр дважды, каждый раз 
     * с новой строки. Тип возвращаемого значения метода Twice() определите самостоятельно. 
     * Внутри метода Main() вызовите метод Twice() и передайте ему введённую с клавиатуры строку.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            string someText;

            Console.Write("Введите какой нибудь текст и нажмит Enter: ");
            someText = Console.ReadLine();
            Twice(someText);
        }

        static void Twice(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine(message);
        }        
    }
}