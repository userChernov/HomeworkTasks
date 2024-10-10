using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11
{
    /*
     +* Создайте классы Dog и Cat в том же файле и том же namespace, что и класс Program. 
     +* Создайте класс Human в том же файле и том же namespace, что и класс Program, а также объявите в нём строковую переменную name. 
     +* Измените классы Cat и Dog таким образом, чтобы у них появилось поле owner, подумайте, какого типа оно должно быть. 
     +* Внутри метода Main() класса Program создайте два экземпляра класса Human, присвойте их переменным catOwner 
     +* и dogOwner, и по одному экземпляру классов Cat и Dog, присвойте их переменным с произвольными именами. 
     +* Присвойте экземпляру catOwner имя Вася, а экземпляру dogOwner - имя Марго. Сделайте так, чтобы у каждого 
     +* из созданных животных появился владелец и выведите их имена на экран в следующих форматах: 
     +* "Владельца кота зовут: ХХХ", "Владельца собаки зовут: ХХХ", где ХХХ - имена владельцев животных, каждый вывод с новой строки. 
     +* Все создаваемые элементы делайте публичными.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */

            Human catOwner = new Human();
            Human dogOwner = new Human();
            Cat cat1 = new Cat();
            Dog dog1 = new Dog();

            catOwner.name = "Вася";
            dogOwner.name = "Марго";

            cat1.owner = catOwner.name;
            dog1.owner = dogOwner.name;

            Console.WriteLine($"Владельца кота зовут: {cat1.owner}");
            Console.WriteLine($"Владельца собаки зовут: {dog1.owner}");
        }
    }
    /* Добавьте свой код ниже */

    public class Dog
    {
        public Human owner;
    }

    public class Cat
    {
        public Human owner;
    }

    public class Human
    {
        public string name;
    }
}