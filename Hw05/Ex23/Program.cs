using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex23
{
    /*
     * Для класса SpaceDog создайте следующие свойства:
     *      1) Name.
     *      2) Age.
     *      3) IsInSpace.
     *      4) IsGoingToSleep.
     *      5) IsAtHome.
     * Для класса SpaceDog создайте конструктор, который принимает: имя, возраст и статус бодрствования.
     * Свойства IsInSpace и IsAtHome реализуйте таким образом, чтобы они всегда имели противоположные
     * значения.
     * Переопределите метод ToString() для класса SpaceDog, чтобы он выводил информацию об экземпляре в следующем формате:
     * "Меня зовут ХХХ, я первый космонавт! Мне ХХХ лет, я нахожусь дома\в космосе. Я скоро пойду спать\Я недавно проснулся!"
     * Итоговая строка должна зависеть от значений соответствующих свойств экземпляра класса SpaceDog.
     */

    public class SpaceDog
    {
        /* Добавьте свой код ниже */
        public string Name { set; get; }
        public int Age { set; get; }
        public bool IsInSpace { set; get; }
        public bool IsGoingToSleep { set; get; }
        public bool IsAtHome { set; get; }

        public SpaceDog(string name, int age, bool isGoingToSleep)
        {
            this.Name = name;
            this.Age = age;
            this.IsGoingToSleep = isGoingToSleep;

            Random rand = new Random();

            if (rand.Next(2) == 0)
            {
                IsAtHome = false;
                IsInSpace = true;
            }
            else
            {
                IsAtHome = true;
                IsInSpace = false;
            }
        }

        public override string ToString()
        {
            string baseText = $"Меня зовут {Name}, я первый космонавт! Мне {Age} лет,";
            string terms1;
            string terms2;

            if (this.IsAtHome)
                terms1 = " я нахожусь дома. ";
            else
                terms1 = " я нахожусь в космосе. ";

            if (IsGoingToSleep)
                terms2 = "Я скоро пойду спать!";
            else
                terms2 = "Я недавно проснулся!";

            return baseText + terms1 + terms2;
        }

        public static void Main(string[] args)
        {
            SpaceDog belka = new SpaceDog("belka", 3, false);
            SpaceDog strelka = new SpaceDog("strelka", 2, true);

            Console.WriteLine(belka);
            Console.WriteLine(strelka);

        }

        /* Добавьте свой код ниже */
    }
}
