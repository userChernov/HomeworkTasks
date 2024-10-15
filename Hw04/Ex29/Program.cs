using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex29
{
    /*
     * В классе Program создайте статический метод TillTheEnd() так, чтобы он считывал строки с клавиатуры
     * и выводил их в консоль (каждую с новой строки) до тех пор, пока не будет введена строка end. 
     * Строку end выводить в консоль не нужно.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            TillTheEnd();
        }

        public static void TillTheEnd()
        {
            string input = "";

            while (input != "end")
            {
                input = Console.ReadLine();
                if (input != "end") Console.WriteLine(input);
            }
        }

    }
}
