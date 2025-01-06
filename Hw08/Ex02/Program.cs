using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace l8t2
{
    /*
   * Измените тип статической переменной list класса Program так, чтобы она стала обладать аналогичным поведением, но
   * являлась параметризированным списком. Внутри метода Main() добавьте в список list 20 элементов - экземпляров классов Cat и Dog.
   * При этом каждый 5-й элемент списка list должен являться экземпляром класса Dog, а остальные элементы списка - экземпляры класса Cat.
   * Остальные элементы шаблона изменять нельзя.
   */


    public class Program
    {
        public static ArrayList list = new ArrayList();


        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */


            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }


    public class Cat
    {
        public string Name { get; set; }


        public Cat(string name)
        {
            Name = name;
        }


        public override string ToString()
        {
            return $"Я котик по имени {Name}";
        }
    }


    public class Dog
    {
        public string Name { get; set; }


        public Dog(string name)
        {
            Name = name;
        }


        public override string ToString()
        {
            return $"Я собачка по имени {Name}";
        }
    }
}
