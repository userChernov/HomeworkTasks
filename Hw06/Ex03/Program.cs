using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l6t3
{
    /*
     *+ Пусть у каждой кошки есть имя, кошка-папа(fatherCat) и кошка-мама(motherCat).
     *+ Создайте класса Cat, который бы описывал данную ситуацию, все поля класса - публичные.
     * Внутри метода Main() создайте 8 экземпляров класса Cat, каждый в своей переменной, 
     * которые бы описывали следующую кошачью семью:
     *      1) Кота-дедушку по маме(не имеет родителей).
     *      2) Кота-бабушку по маме(не имеет родителей).
     *      3) Кота-дедушку по папе(не имеет родителей).
     *      4) Кота-бабушку по папе(не имеет родителей).
     *      5) Кота-маму.
     *      6) Кота-папу.
     *      7) Двух котят.
     * Переопределите метод ToString() класса Cat, так чтобы он выводил информацию в следующем формате:
     * "Имя: ХХХ"
     * "Имя кота-мамы: ХХХ"
     * "Имя кота-папы: ХХХ"
     * "Имена бабушек: ХХХ,XXX"
     * "Имена дедушек: ХХХ,XXX"
     * Для класса Cat создайте конструктор, который принимает имя и два родительских объекта.
     * Внутри метода Main() выведите в консоль информацию о двух котятах. Все элементы класса Cat должны быть публичными.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Cat fatherFather = new Cat("grandpa1");
            Cat fatherMother = new Cat("grandpa2");

            Cat motherMother = new Cat("granny1");
            Cat motherFather = new Cat("granny2");

            Cat mother = new Cat("mother", motherMother, fatherMother);
            Cat father = new Cat("father", motherFather, fatherFather);

            Cat cat1 = new Cat("I am Cat1", mother, father);
            Cat cat2 = new Cat("I am Cat2", mother, father);

            Console.WriteLine(cat1);
            Console.WriteLine(cat2);

        }
    }

    public class Cat
    {
        public string name;
        public Cat fatherCat;
        public Cat motherCat;

        public Cat(string name, Cat motherCat = null, Cat fatherCat = null)
        {
            this.name = name;
            this.motherCat = motherCat;
            this.fatherCat = fatherCat;
        }

        public override string ToString()
        {

            Console.WriteLine($"Имя: {this.name}");
            Console.WriteLine($"Имя кота-мамы: {this.motherCat.name}");
            Console.WriteLine($"Имя кота-папы: {this.fatherCat.name}");
            Console.WriteLine($"Имена бабушек: {this.motherCat.motherCat.name}, {this.fatherCat.motherCat.name}");
            Console.WriteLine($"Имена дедушек: {this.motherCat.fatherCat.name}, {this.fatherCat.fatherCat.name}");

            return "";

        }
    }
}
