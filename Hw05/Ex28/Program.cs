using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ex28
{
    /*
     * Реализуйте класс Bird таким образом, чтобы:
     *      1) Он имел 3 автоматических свойства: Name, Age, Speed.
     *      2) Свойства Age и Speed имели стартовые значения равные 100.
     * Добавьте в класс Bird публичный метод ChangeObject(), который:
     *      1) Принимает строку-имя в качестве входящего параметра.
     *      2) Устанавливает значение Age равное 50, если полученная строка начинается с заглавной буквы.
     *      3) Устанавливает значение Speed 10, если полученная строка заканчивается заглавной буквой.
     *      4) Умножает значение Age на 2, если полученная строка заканчивается цифрой.
     */

    public class Bird
    {
        /* Добавьте свой код ниже */
        public string Name { set; get; } = "";
        public int Age  { set; get; } = 100;
        public int Speed { set; get; } = 100;

        public static void Main(string[] args)
        {
            Console.Write("Enter Name: ");

            string name = Console.ReadLine();

            Bird bird1 = new Bird();

            bird1.ChangeObject(name);

            Console.WriteLine(bird1);
        }

        public void ChangeObject(string name)
        {
            this.Name = name;
            
            if (char.IsUpper(name[0]))
                this.Age = 50;
            
            if (char.IsUpper(name[name.Length - 1]))
                this.Speed = 10;

            if (char.IsNumber(name[name.Length - 1]))
                this.Age = this.Age * 2;
        }

        // qwerq

        public override string ToString()
        {
            return $"Name = {this.Name} : Age = {this.Age} : Speed = {this.Speed}";
        }
    }
}
