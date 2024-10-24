using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12
{
    /*
     * +Создайте новый класс Cat в том же файле и том же namespace, что и класс Program.
     * +В классе Cat создайте 4 переменные, которые будут отвечать за: имя(name), возраст(age), пол(gender) и владельца кота(owner).
     * +Имена, типы переменных и модификатор доступа переменных и классов определите самостоятельно.
     * +Создайте конструкторы класса Cat, которые принимают в себя:
     *      1) Имя.
     *      2) Имя и возраст.
     *      3) Имя и возраст и пол.
     * Созданные конструкторы должны инициализировать значениями все переменные класса.
     * Значения для инициализации по умолчанию: возраст - 1; пол - true, владелец - новый экземпляр класса Human.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Cat cat1 = new Cat("Мурзик");
            Cat cat2 = new Cat("Мурзик", 3);
            Cat cat3 = new Cat("Мурзик", 5, false);

            Console.WriteLine(cat1);
            Console.WriteLine(cat2);
            Console.WriteLine(cat3);
        }
    }

    public class Cat
    {
        public string name;
        //public int age = 1;
        public int age;
        //public bool gender = true;
        public bool gender;
        //public Human owner = new Human() { name = "Хозяин" };
        public Human owner;

        public Cat(string name)
        {
            this.name = name;
            this.age = 1;
            this.gender = true;
            this.owner = new Human() { name = "Хозяин" };
        }
        public Cat(string name, int age)
        {
            this.name = name;
            this.age = age;
            this.gender = true;
            this.owner = new Human() { name = "Хозяин" };
            
        }
        public Cat(string name, int age, bool gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.owner = new Human() { name = "Хозяин" };

        }

        public override string ToString()
        {
            return $"{name} : {age} : {gender} : {owner}";
        }

    }

    public class Human
    {
        public string name;

        public override string ToString()
        {
            return $"{name}";
        }
    }
}
