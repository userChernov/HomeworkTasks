using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l7t19
{
    /*
     * Реализуйте класс Cat, он должен:
     *      1) Содержать свойство Id.
     *      2) Содержать конструктор, который принимает один целочисленный параметр и присваивает его свойству.
     *      3) Переопределите метод ToString() так, чтобы он выводил фразу "Я котик и мой id = XXX". XXX - Id экземпляра класса.
     *      4) Создайте статический метод GetFreshKitties(), который  возвращает 100 экземпляров класса Cat со случайными значениями Id
     * в диапазоне от 1 до 50 включительно.
     * Внутри метода Main() создайте две коллекции экземпляров класса Cat. Пусть первая коллекция содержит в себе результат вызова
     * метода GetFreshKitties(), а вторая содержит перечень экземпляров класса Cat с уникальными ID из первой коллекции.
     * Выведите на экран все элементы второй коллекции, каждое значение с новой строки. Для вывода используйте цикл foreach.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            List<Cat> myCats = new List<Cat>();
            Dictionary<int, Cat> myUnicCats = new Dictionary<int, Cat>();

            myCats = Cat.GetFreshKitties();

            foreach (var item in myCats)
            {
                if ( !myUnicCats.ContainsKey(item.Id) )
                    myUnicCats.Add(item.Id, item);

            }

            foreach (var item in myCats)
                Console.WriteLine(item);

            Console.WriteLine();

            foreach (var item in myUnicCats)
                Console.WriteLine(item);

        }
    }

    public class Cat
    {
        public int Id;

        public Cat(int id)
        {
            this.Id = id;
        }

        public override string ToString()
        {
            return $"Я котик и мой id = {this.Id}";
        }

        public static List<Cat> GetFreshKitties()
        {
            Random rand = new Random();
            List<Cat> cats = new List<Cat>();

            for (int i = 0; i < 100; i++)
            {
                Cat cat = new Cat(rand.Next(1, 51));
                cats.Add(cat);
            }

            return cats;
        }

    }

}

