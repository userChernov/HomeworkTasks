using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l6t1
{
    /*
     * Реализуйте класс Cat, таким образом, чтобы:
     *      1) Класс содержал приватное статическое поле catCount, со значением 0 по умолчанию.
     *      2) Создайте свойство для поля catCount, которое позволяет только чтение значения этого поля.
     *      3) При помощи конструктора класса Cat, реализуйте логику подсчета созданных экземпляров класса Cat.
     *      4) Поле catCount должно хранить в себе число созданных экземпляров класса Cat.
     * Шаблон задачи изменять нельзя.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 0; i < 500; i++)
            {
                new Cat();
            }
            Console.WriteLine(Cat.CatCount);
        }
    }

    public class Cat
    {
        private static int catCount;

        public static int CatCount
        {
            get { return catCount; }
            set { }
        }

        public Cat()
        {
            catCount++;
        }
        /* Добавьте свой код ниже */
    }
}