using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex29
{
    /*
     * Создайте публичный статический класс SimpleSupportClass в том же файле и namespace что и класс Program.
     * Добавьте в созданный класс 3 приватных поля и 3 свойства. Название и типы могут быть произвольными.   
     */

    public class Program
    {
        public static void Main(string[] args)
        {
        }
    }

    /* Добавьте свой код ниже */

    public static class SimpleSupportClass
    {
        static int value1;
        static string value2;
        static bool value3;
        static int Value4 { get; set; }
        static string Value5 { get; set; }
        static bool Value6 { get; set; }
    }

}
