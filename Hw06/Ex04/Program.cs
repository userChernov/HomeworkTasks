using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l6t4
{
    /*
     * Создайте класс Human, который должен содержать свойства: имя(name), пол(sex), возраст(age). Свойство пол сделайте
     * логического типа, на основе следующей формальной логики: true - мужской пол, false - женский. Типы остальных
     * свойств класса определите самостоятельно.Все элементы класса Human должны быть публичными.
     * Переопределите метод ToString() класса Human, так чтобы он выводил информацию об экземпляре класса в следующем формате:
     * "Меня зовут ХХХ, я мужчина\женщина, мне ХХХ лет.", где ХХХ - соответствующие значения свойств класса Human,
     * а выбор значения мужчина\женщина зависел от значения свойства, отвечающего за пол.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            Human man = new Human() {name = "Олег", sex = true, age = 21};
            Human women = new Human() {name = "Наталья", sex = false, age = 29};

            Console.WriteLine(man);
            Console.WriteLine(women);
        }
    }

    /* Добавьте свой код ниже */
    public class Human
    {
        public string name;
        public bool sex;
        public int age;

        public override string ToString()
        {
            string textSex;
            if (sex)
                return $"Меня зовут {this.name}, я мужчина, мне {this.age} лет";
            else
                return $"Меня зовут {this.name}, я женщина, мне {this.age} лет";
        }
    }

}
