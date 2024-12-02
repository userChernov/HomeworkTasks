using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ex10
{

    /*
     * Создайте новый публичный класс Dog в том же файле и том же namespace, что и класс Program. 
     * Объявите в классе Dog три переменные: name,age,breed, тип и модификатор доступа переменных определите самостоятельно. 
     * Переопределите метод ToString() для класса Dog так, чтобы он выводил информацию об экземпляре класса в следующем формате: 
     * "Привет!!! Я собачка и меня зовут ХХХ!!! Мне ХХХ лет и я отношусь к породе: ХХХ!". 
     * ХХХ - значения соответствующих переменных класса Dog. 
     * Внутри метода Main() создайте 4 экземпляра класса Dog используя статическую инициализацию и выведите в консоль информацию 
     * по созданным экземплярам, каждый экземпляр с новой строки.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */

            Dog rex = new Dog() {name = "Рекс", age = 7, breed = "Овчарка"};
            Dog chaksa = new Dog() {name = "Чакса", age = 3, breed = "Корги"};
            Dog chernish = new Dog() {name = "Черныш", age = 1, breed = "Пудель"};
            Dog frenk = new Dog() {name = "Фрэнк", age = 4, breed = "Мопс"};

            Console.WriteLine(rex);
            Console.WriteLine(chaksa);
            Console.WriteLine(chernish);
            Console.WriteLine(frenk);
        }
    }
    /* Добавьте свой код ниже */

    public class Dog
    {
        public string name;
        public int age;
        public string breed;

        public override string ToString()
        {
            return $"Привет!!! Я собачка и меня зовут {name}!!! Мне {age} лет и я отношусь к породе: {breed}!";
        }

    }
    
}
