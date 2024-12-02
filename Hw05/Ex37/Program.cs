using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex37
{
    /*
     * +Создайте новый публичный класс Bird в том же файле и том же namespace, что и класс Program. 
     * +Объявите в классе Bird четыре переменные: name, age, breed, continentRU. 
     * +Переменная continentRU должна являться публичным перечислением, содержащим все существующие на текущий момент континенты.
     * +Перечисление должно быть объявлено в том же файле и том же namespace, что и класс Program.
     * +Тип и модификатор доступа остальных переменных определите самостоятельно. 
     * Переопределите метод ToString() для класса Bird так, чтобы он выводил информацию об экземпляре класса в следующем формате: 
     * "Привет!!! Я птичка и меня зовут ХХХ!!! Мне ХХХ лет и я отношусь к породе: ХХХ, которая водится на континенте: ХХХ!".
     * ХХХ - значения соответствующих переменных класса Bird. 
     * Внутри метода Main() создайте 2 экземпляра класса Bird используя статическую инициализацию и выведите в консоль информацию 
     * по созданным экземплярам, каждый экземпляр с новой строки.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Bird crow = new Bird() {name = "Ворона", age = 2, breed = "Врановые", continentRU = continentRU.Europe};
            Console.WriteLine(crow);
            Bird parrot = new Bird() {name = "Попугай", age = 4, breed = "Попугаеобразные", continentRU = continentRU.Australia};
            Console.WriteLine(parrot);
        }
    }
    /* Добавьте свой код ниже */

    public class Bird
    {
        public string name;
        public int age;
        public string breed;
        public continentRU continentRU;

        public override string ToString()
        {
            string continentRU = "";
            switch (Convert.ToInt32(this.continentRU))
            {
                case 0 :
                    continentRU = "Африка";
                    break;                
                case 1 :
                    continentRU = "АЗИЯ";
                    break;                
                case 2 :
                    continentRU = "Европа";
                    break;                
                case 3 :
                    continentRU = "Северная Америка";
                    break;                
                case 4 :
                    continentRU = "Южная Америка";
                    break;                
                case 5 :
                    continentRU = "Антарктика";
                    break;                
                case 6 :
                    continentRU = "Австралия";
                    break;                
            }

            //return $"Привет!!! Я птичка и меня зовут {this.name}!!! Мне {this.age} лет и я отношусь к породе: {this.breed}, которая водится на континенте: {this.continentRU}!";
            return $"Привет!!! Я птичка и меня зовут {this.name}!!! Мне {this.age} лет и я отношусь к породе: {this.breed}, которая водится на континенте: {continentRU}!";
        }
    }

    public enum continentRU
    {
        Africa,
        Asia,
        Europe,
        NorthAmerica,
        SouthAmerica,
        Antarctica,
        Australia
    }
}
