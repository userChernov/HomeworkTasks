using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex15
{
    /*
     *+ Создайте публичный класс Human в том же файле и namespace, что и класс Animal.
     *+ Для класса Animal объявите следующие переменные:
     *+      1) name - отвечающую за имя.
     *+      2) speed - отвечающую за скорость.
     *+      3) age - отвечающую за возраст.
     *+      4) owner - отвечающую за владельца.
     *+ Для класса Human объявите следующие переменные:
     *+      1) name -  отвечающую за имя.
     *+      2) age - отвечающую за возраст.
     *+ Все переменные классов должны быть публичными, тип и остальные модификаторы определите самостоятельно.
     *+ Для класса Animal объявите конструктор, который:
     *+      1) Принимает имя, скорость, возраст и владельца животного, инициализируя соответствующие поля класса.
     *+      2) Всегда присваивает значение имени с заглавной буквы.
     *??????      3) Присваивает значение "Кеша" имени экземпляра, если получена пустая строка с именем.
     *+      4) Присваивает значение 7 возрасту экземпляра, если получено отрицательное или равное 0 значение с возрастом.
     *+      5) Присваивает значение 121 скорости экземпляра, если получено отрицательное или равное 0 значение со скоростью.
     *+      6) Присваивает новый экземпляр класса Human переменной owner с произвольным именем, если имя владельца "Аноним".
     *+ Возраст владельца при этом должен остаться без изменений.
     *+ Для класса Human объявите конструктор, который:
     *+      1) Принимает имя и возраст, инициализируя соответствующие поля класса.
     *+      2) Всегда присваивает значение имени с заглавной буквы.
     *+      3) Присваивает значение "Аноним" имени экземпляра, если получена пустая строка с именем.
     */

    public class Animal
    {
        /* Добавьте свой код ниже */
        public string name;
        public int speed;
        public int age;
        public Human owner;

        public Animal(string name, int speed, int age, Human owner)
        {
            Random rand = new Random();

            if (name != "") 
                this.name = StringEditor.CorrectText(name);
            else
                this.name = "Кеша";
            
            if (age > 0)
                this.age = age;
            else
                this.age = 7;

            if (speed > 0)
                this.speed = speed;
            else
                this.speed = 121;

            if (owner.name == "Аноним")
                this.owner = new Human(Convert.ToString(rand.Next()),owner.age);
            else
                this.owner = owner;    

        }

        // public string CorrectText(string Text)
        // {
        //     TextInfo RuTextInfo = new CultureInfo("ru-RU").TextInfo;
        //     return RuTextInfo.ToTitleCase(RuTextInfo.ToLower(Text));
        // }

        public override string ToString()
        {
            return $"Animal : {name} : {speed} : {age} .. Owner : {owner.name} : {owner.age}";
        }

        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            //Human arkady = new Human("Arkady", 31);
            Human owner1 = new Human("Arkady", 7);
            Human owner2 = new Human("", 31);

            Animal cat1 = new Animal("bArSik", 11, 31, owner1);
            Animal cat2 = new Animal("", 0, -10, owner2);

            Console.WriteLine(cat1);
            Console.WriteLine(cat2);
        }
    }

    /* Добавьте свой код ниже */
    public class Human
    {
        public string name;
        public int age;

        public Human(string name, int age)
        {
            if (name != "")
                this.name = StringEditor.CorrectText(name);
            else
                this.name = "Аноним";

            this.age = age;
        }

    }

    public static class StringEditor
    {
        public static string CorrectText(string Text)
        {
            TextInfo RuTextInfo = new CultureInfo("ru-RU").TextInfo;
            return RuTextInfo.ToTitleCase(RuTextInfo.ToLower(Text));
        }
    }

}
