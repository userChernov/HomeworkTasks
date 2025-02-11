using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l10t16
{
    /*
     * Создайте методы:
     *      1) Method1() - должен принимать символьную переменную и возвращать true если полученный символ является цифрой.
     *      2) Method2() - должен принимать символьную переменную и возвращать true если полученный символ является знаком.
     *      3) Method3() - должен принимать символьную переменную и возвращать true если полученный символ в верхнем регистре.
     *      4) Method4() - должен принимать символьную переменную и возвращать true если полученный символ является управляющим элементом.
     * Шаблон задачи изменять нельзя.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Method1('q'));
            Console.WriteLine(Method2('q'));
            Console.WriteLine(Method3(' '));
            Console.WriteLine(Method4('3'));
            Console.WriteLine(Method1('1'));
            Console.WriteLine(Method2('+'));
            Console.WriteLine(Method3('T'));
            Console.WriteLine(Method4('\n'));
        }

        /* Добавьте свой код ниже */
        public static bool Method1(char a)
        {
            return Char.IsNumber(a);
        }
        public static bool Method2(char a)
        {
            return Char.IsPunctuation(a);
        }
        public static bool Method3(char a)
        {
            return Char.IsUpper(a);
        }
        public static bool Method4(char a)
        {
            return Char.IsControl(a);
        }

    }
}

