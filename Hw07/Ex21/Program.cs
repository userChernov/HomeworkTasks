using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l7t21
{
    /*
     *+ Создайте класс Cat с публичным свойством Name. Переопределите для класса Cat метод ToString() так, чтобы он выводил фразу:
     *+ "Котик - ХХХ", где XXX - значение свойства Name.
     *+ Создайте для класса Cat конструктор, который принимает и устанавливает значение для свойства класса Cat.
     *+ Внутри метода Main() создайте словарь, ключ - число (порядковый номер созданного кота), значение - экземпляр класса Cat.
     *+ Создайте 10 экземпляров класса Cat и поместите их в словарь. Первый добавленный элемент словаря должен иметь значение ключа 1.
     * Выведите на экран все элементы словаря, каждый с новой строки, в следующем формате:
     * "В клетке №key сидит value", где key и value соответствующие значения элемента словаря.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */

            Dictionary<int, Cat> cats = new Dictionary<int, Cat>();
            List<string> names = new List<string>() {"barsik", "murzik", "panda", "Jimmy", "shprot", "elli", "klepa", "roza", "lev", "tommy"};

            for (int i = 0; i < names.Count; i++)
            {
                Cat cat = new Cat(names[i]);

                cats.Add(i+1, cat);
            }

            foreach (var item in cats)
            {
                Console.WriteLine($"В клетке №{item.Key} сидит {item.Value}");
            }
        }
    }

    public class Cat
    {
        public string Name;

        public Cat(string name)
        {
            this.Name = name;
        }

        public override string ToString()
        {
            return $"Котик - {this.Name}";
        }
    }
    /* Добавьте свой код ниже */
}

