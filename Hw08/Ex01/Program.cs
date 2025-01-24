using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace l8t1
{
    /*
     * Внутри метода Main() заполните динамический массив list 10 экземплярами класса Cat и 10 экземплярами класса Dog.
     * Каждый второй элемент динамического массива должен являться экземпляром класса Cat, а остальные класса Dog.
     * Шаблон задачи изменять нельзя.
     */


    public class Program
    {
        public static ArrayList list = new ArrayList();


        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */

            for (int i = 0; i < 10; i++)
            {
                if ( i % 2 != 0 )
                    list.Add(new Cat($"Котик №{i}"));
                else
                    list.Add(new Dog($"Пес №{i}"));

            }


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
