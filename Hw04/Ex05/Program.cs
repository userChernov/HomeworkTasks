using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05
{
    /*
     * Создайте новый класс Cat в том же файле и том же namespace, что и класс Program. 
     * Внутри класса Cat объявите статическую переменную counter, которая будет хранить в себе количество котов. 
     * Пусть она будет равна 0, тип и модификатор доступа определите самостоятельно.
     * Добавьте метод AddCat(), который будет увеличивать значение счетчика на 1 при каждом вызове.
     * В методе Main() создайте 3 экземпляра класса Cat и вызовите у них метод AddCat().
     * Выведите значение счетчика котов на экран.
     */
    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */

            Cat cat1 = new Cat();
            Cat cat2 = new Cat();
            Cat cat3 = new Cat();

            cat1.AddCat();
            cat2.AddCat();
            cat3.AddCat();

            Console.WriteLine($"Счетчик котов показывает {Cat.counter}");

        }
    }

    /* Добавьте свой код ниже */
    public class Cat
    {
        public static int counter = 0;

        public void AddCat()
        {
            counter ++;
        }
    }
}
