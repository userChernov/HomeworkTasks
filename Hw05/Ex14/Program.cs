using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ex14
{
    /*    
     *+ Реализуйте класс Cat и класс Human. Для класса Cat объявите два поля класса:
     *+      1) Имя.
     *+      2) Владелец.
     *+ Создайте конструктор для класса Cat, который принимает имя в качестве параметра, кроме того
     * внутри конструктора создайте и присвойте соответствующему полю класса Cat новый экземпляр
     * класса Human.
     * Для класса Human объявите три поля класса:
     *      1) Имя.
     *      2) Адрес.
     *      3) Питомец.
     * Для класса Human добавьте такой конструктор, чтобы при создании нового экземпляра класса Human его имя
     * совпадало с вашим, адрес был произвольным, а в качестве входящего параметра конструктор бы принимал
     * и присваивал соответствующему полю новый экземпляр класса Cat.
     * Для класса Cat переопределите метод ToString(), так чтобы он возвращал информацию в следующем формате:
     * "Меня зовут: XXX, а моего хозяина зовут: ХХХ. Мы с ним вместе живем по адресу: ХХХ!"
     * ХХХ - значения соответствующих полей класса. Все элементы классов Cat и Human сделайте открытыми.
     * Шаблон задачи менять нельзя.
     */

    public class Program
    {        
        public static void Main(string[] args)
        {
            Console.WriteLine(new Cat("Барсик"));
            Console.WriteLine(new Cat("Мурзик"));
            Console.WriteLine(new Cat("Том"));
        }
    }

    public class Cat
    {
        /* Добавьте свой код ниже */
        public string name;
        public Human owner;

        public Cat(string name)
        {
            this.name = name;
            this.owner = new Human(this);
          
        }

        public override string ToString()
        {
            return $"Меня зовут: {name}, а моего хозяина зовут: {owner.name}. Мы с ним вместе живем по адресу: {owner.address}!";
        }
    }

    public class Human
    {
        /* Добавьте свой код ниже */
        public string name;
        public string address;
        public Cat pet;
        
        public Random rand = new Random();


        public Human(Cat pet)
        {
            this.name = "Anton";
            this.address = Convert.ToString(rand.Next());
            this.pet = pet;
        }

    }
}
