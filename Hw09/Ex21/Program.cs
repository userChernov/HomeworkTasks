using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l9t21
{
    /*
     * Внутри метода Main() дан массив строк strings. Реализуйте метод ReturnCorrectString(), который должен:
     *      1) Принимать в себя массив строк.
     *      2) Возвращать строку, которая содержит все элементы полученного массива строк, разделенные знаком %.
     * В конце передаваемой строки не должно быть бесполезного знака %.
     * Шаблон задачи изменять нельзя.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            string[] strings = new string[10] { "каждый", "охотник", "желает", "знать", "где", "сидит", "что", "-", "нибудь", "вкусное!" };
            Console.WriteLine(ReturnCorrectString(strings));
        }

        public static string ReturnCorrectString(string[] strings)
        {
            /* Добавьте свой код ниже */
            string result = "";

            foreach (string value in strings)
            {
                result += value + "%";
            }

            return result.Remove(result.Length - 1);
        }
    }
}
