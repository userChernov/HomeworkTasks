using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex36
{
    /*
     * Создайте публичное перечисление AllAnimals в том же namespace и файле что и класс Program.
     * Перечисление AllAnimals должно содержать 5 элементов: Dog, Cat, Monkey, Bird, Elephant.
     * Сделайте так, чтобы каждый из элементов перечисления был ассоциирован со следующими целочисленными значениями:
     * Dog - 10, Cat - 5, Monkey - 15, Bird - 1, Elephant - 100.
     * Измените класс Animal таким образом, чтобы в нём появились:
     *      1) Автоматическое свойство, отвечающее за тип животного.
     *      2) Приватное поле вес и соответствующее публичное свойство.
     * Публичное свойство, отвечающее за вес должно:
     *      1) Возвращать значение поля вес.
     *      2) Устанавливать значение поля, путём умножения переданного значения на коэффициент, ассоциируемый с типом животного.
     * Внутри метода Main() установите каждому из созданных экземпляров класса Animal соответствующий тип, с учетом названия переменных,
     * хранящих в себе ссылку на созданные экземпляры.
     * Остальные элементы шаблона изменять нельзя.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            Animal cat = new Animal("Котик");
            Animal dog = new Animal("Собачка");
            Animal monkey = new Animal("Мартышка");
            Animal bird = new Animal("Птичка");
            Animal elephant = new Animal("Слоник");

            /* Добавьте свой код ниже */
            cat.Type = AllAnimals.Cat;
            dog.Type = AllAnimals.Dog;
            monkey.Type = AllAnimals.Monkey;
            bird.Type = AllAnimals.Bird;
            elephant.Type = AllAnimals.Elephant;

            cat.Weight = 100;
            dog.Weight = 100;
            monkey.Weight = 100;
            bird.Weight = 100;
            elephant.Weight = 100;

            Console.WriteLine(cat.Weight);
            Console.WriteLine(dog.Weight);
            Console.WriteLine(monkey.Weight);
            Console.WriteLine(bird.Weight);
            Console.WriteLine(elephant.Weight);
        }
    }

    public class Animal
    {
        private int weight;
        public string Name { get; set; }
        public int Age { get; set; }
        public int Weight
        {
            get { return weight; }
            set { this.weight = value * Convert.ToInt32(this.Type); }
        }
        /* Добавьте свой код ниже */
        public AllAnimals Type { get; set; }

        public Animal(string name)
        {
            Name = name;
            Weight = 100;
        }
    }

    /* Добавьте свой код ниже */

    public enum AllAnimals
    {
        Dog = 10,
        Cat = 5,
        Monkey = 15,
        Bird = 1,
        Elephant = 100
    }
}
