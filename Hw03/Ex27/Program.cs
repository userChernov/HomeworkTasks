using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex27
{
    /*
     * Проанализируйте код шаблона, подумайте почему, программа не компилируется, и внесите соответствующие изменения, 
     * чтобы программа скомпилировалась. В методе Main() необходимо изменить последний вывод в консоль таким образом, 
     * чтобы в консоль была выведена правильная строка в формате: "Владельца кота по имени ХХХ зовут ХХХ, а по профессии 
     * он: ХХХ", где ХХХ - значение соответствующих полей и переменных.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            Cat cat = new Cat();
            Dog dog = new Dog();
            Human human = new Human();

            cat.owner = human;
            cat.name = "Мурка";
            //??????human.age = 28;
            dog.owner = human;
            dog.owner.SetName("Иван");
            human.profession = "Инженер";
            Console.WriteLine("Владельца кота по имени " + cat.name + " зовут " + cat.owner.name + " ,а по профессии он : " + human.profession);
        }
    }

    public class Cat
    {
        public string name;
        private const int age = 1;
        public Human owner;
    }

    
    public class Dog
    {
        private const int taisCount = 1;
        public Human owner;
        Cat cat;
    }
    

    public class Human
    {
        public string name;
        public string profession;

        public void SetName(string a)
        {
            name = a;
        }
    }

}