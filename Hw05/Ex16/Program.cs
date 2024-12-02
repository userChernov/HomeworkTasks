using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace Ex16
{
    /*
     * Для класса Human, создайте конструктор, который бы принимал имя, возраст и профессию человека и инициализировал полученными значениями соответствующие поля класса.
     * Переопределите метод ToString для класса Human, таким образом, чтобы:
     * 1) Он возвращал строку "Привет, меня зовут ХХХ, мне ХХХ лет и по профессии я: ХХХ!".
     * 2) Если значение возраста меньше либо равно нулю, то возвращал строку "Привет, меня зовут ХХХ, я скрываю свой возраст, потому что по профессии я: ХХХ!".
     * 3) Если значение имени null или пустая строка, то возвращал строку "Привет, я скрываю своё имя, но мне ХХХ лет и я работаю по профессии: ХХХ!".
     * 4) Если значение профессии null или пустая строка, то возвращал строку "Привет, меня зовут ХХХ, мне ХХХ лет, у меня пока нет профессии, но скоро я стану .Net программистом!!!".
     * 5) Если значения возраста и профессии пустые или некорректные, то возвращал строку "Меня зовут ХХХ!"
     * 6) Если значения имени и возраста пустые или некорректные, то возвращал строку "Моя профессия ХХХ!".
     * 7) Если значения имени и профессии пустые, то возвращал строку "Мне ХХХ лет!".
     * 8) Если все значения пустые или некорректные, то возвращал строку "Я аноним!".
     * Шаблон задачи изменять нельзя.
     */

    public class Human
    {
        private string name;
        private int age;
        private string profession;
        /* Добавьте свой код ниже */

        public Human(string name, int age, string profession)
        {
            this.name = name;
            this.age = age;
            this.profession = profession;
        }

        
        public static void Main(string[] args)
        {
            Human human1 = new Human("human1", 1, "prof1");
            Human human2 = new Human("human2", -2, "prof2");
            Human human3 = new Human("", 3, "prof3");
            Human human4 = new Human("human4", 4, "");
            Human human5 = new Human("human5", -5, "");
            Human human6 = new Human("", -6, "prof6");
            Human human7 = new Human("", 7, "");
            Human human8 = new Human("", -8, "");

            Console.WriteLine(human1);
            Console.WriteLine(human2);
            Console.WriteLine(human3);
            Console.WriteLine(human4);
            Console.WriteLine(human5);
            Console.WriteLine(human6);
            Console.WriteLine(human7);
            Console.WriteLine(human8);

        }
        /* Добавьте свой код ниже */

        /* Метод В ЛОБ
                public override string ToString()
                {
                    string result = $"Привет, меня зовут {name}, мне {age} лет и по профессии я: {profession}!";

                    if (age <= 0)
                        result = $"Привет, меня зовут {name}, я скрываю свой возраст, потому что по профессии я: {profession}!";

                    if (name == null || name == "")
                        result = $"Привет, я скрываю своё имя, но мне {age} лет и по профессии я: {profession}!";

                    if (profession == null || profession == "")
                        result = $"Привет, меня зовут {name}, мне {age} лет, у меня пока нет профессии, но скоро я стану .Net программистом!!!";

                    if (age <= 0 && (profession == "" || profession == null))
                        result = $"Меня зовут {name}!";

                    if ((name == null || name == "") && age <= 0)
                        result = $"Моя профессия {profession}!";

                    if ((name == null || name == "") && (profession == "" || profession == null))
                        result = $"Мне {age} лет!";

                    if ((name == null || name == "") && (age <= 0) && (profession == null || profession == ""))
                        result = $"Я аноним!";

                    return result;
                }
        */

        public override string ToString()
        {
            string result = $"Привет, меня зовут {name}, мне {age} лет и по профессии я: {profession}!";

            bool incorrectName = DataChecking(name);
            bool incorrectAge = DataChecking(age);
            bool incorrectProfession = DataChecking(profession);

            if (incorrectAge)
                result = $"Привет, меня зовут {name}, я скрываю свой возраст, потому что по профессии я: {profession}!";

            if (incorrectName)
                result = $"Привет, я скрываю своё имя, но мне {age} лет и по профессии я: {profession}!";

            if (incorrectProfession)
                result = $"Привет, меня зовут {name}, мне {age} лет, у меня пока нет профессии, но скоро я стану .Net программистом!!!";

            if (incorrectAge && incorrectProfession)
                result = $"Меня зовут {name}!";

            if (incorrectName && incorrectAge)
                result = $"Моя профессия {profession}!";

            if (incorrectName && incorrectProfession)
                result = $"Мне {age} лет!";

            if (incorrectName && incorrectAge && incorrectProfession)
                result = $"Я аноним!";


            return result;
        }

        public bool DataChecking(string s)
        {
            return (s == null || s == "") ? true : false;
        }
        public bool DataChecking(int a)
        {
            return a <= 0 ? true : false;
        }

    }
}
