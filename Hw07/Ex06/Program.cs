using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l7t6
{
    /*
     * Реализуйте класс Cat, он должен:
     *      1) Содержать свойство Id.
     *      2) Содержать конструктор, который принимает один целочисленный параметр и присваивает его свойству.
     *      3) Переопределите метод ToString() так, чтобы он выводил фразу "Я котик и мой id = XXX". XXX - Id экземпляра класса.
     * Внутри метода Main() создайте коллекцию экземпляров класса Cat. Создайте 100 экземпляров класса Cat, а
     * в созданную коллекцию добавьте только котов с четными значениями id.
     * Выведите на экран содержимое коллекции, каждое значение с новой строки. Циклом foreach пользоваться нельзя.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            List<Cat> evenCats = new List<Cat>();

            for (int i = 0; i < 100; i++)
            {
                Cat cat = new Cat(i);

                if (i % 2 == 0)
                {
                    evenCats.Add(cat);
                }
            }

            List<Cat>.Enumerator it = evenCats.GetEnumerator();
            while (it.MoveNext())
                Console.WriteLine(it.Current);
        }
    }

    public class Cat
    {
        /* Добавьте свой код ниже */
        public int Id;

        public Cat(int id)
        {
            this.Id = id;
        }

        public override string ToString()
        {
            return $"Я котик и мой id = {this.Id}";
        }
    }
}

