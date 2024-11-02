using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex24
{
    /*
     * Дополните метод Main() класса Program таким образом, чтобы:
     *      1) Экземпляры, на которые ссылаются переменные сat1, cat3, cat4 стали недостижимыми, а сами переменные стали содержать пустую ссылку.
     *      2) Переменные cat2 и сat5  стали ссылаться на 1 объект - ссылка на который доступна из переменной cat6.
     *      3) Переменная cat7 стала ссылаться на значение, хранимое в переменной cat3.
     * Остальные элементы шаблона изменять нельзя.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            Cat cat1 = new Cat();
            Cat cat2 = new Cat();
            Cat cat3 = new Cat();
            Cat cat4 = new Cat();
            Cat cat5 = new Cat();
            Cat cat6 = new Cat();
            Cat cat7 = new Cat();

            /* Добавьте свой код ниже */

            cat1 = null;
            cat3 = null;
            cat4 = null;

            cat2 = cat6;
            cat5 = cat6;
            cat7 = cat3;

            Console.WriteLine(cat1 == cat3 && cat3 == cat4);
            Console.WriteLine(cat3 == cat5 && cat2 == cat6);
            Console.WriteLine(cat2 == cat5 && cat5 == cat6);
            Console.WriteLine(cat1 == cat7 && cat4 == cat5);
            Console.WriteLine(cat7 == cat3 && cat3 == cat1);
        }
    }

    public class Cat {}
}
