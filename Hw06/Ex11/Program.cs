using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l6t11
{
    /*
     * Проанализируйте шаблон. Измените необходимые строки, связанные с методом ChangeStringValue() таким образом,
     * чтобы в результате его работы все принятые им строки изменяли своё значение.
     * Остальные элементы шаблона оставьте без изменений.
     */

    public class Program
    {
        public string s = "Красивая строка №1";

        public static void Main(string[] args)
        {
            Program p = new Program();
            Cat cat = new Cat();

            p.ChangeStringValue(ref p.s);
            p.ChangeStringValue(ref cat.name);

            Console.WriteLine(p.s);
            Console.WriteLine(cat.name);
        }

        public void ChangeStringValue(ref string s)
        {
            s = "ЧТО-ТО НОВОЕ";
        }

        public class Cat
        {
            public string name = "Красивое имя котика";
        }
    }
}
