using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex26
{
    /*
     * Внутри класса Cat объявлены поля класса, но модификаторы доступа и модификаторы static и const расставлены неверно.
     * Сделайте так, чтобы программа компилировалась и выводила в консоль фразу:
     * "В магической дуэли победит тот Кот, у которого показатель magicPower будет больше чем у противника".
     * Содержимое метода Main() изменять нельзя.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            Cat cat = new Cat();
            cat.name = "Кот";
            Cat.condition = "больше";
            cat.field = "magicPower";
            cat.value = Cat.sample;
            Console.WriteLine(cat.value + " магической дуэли победит тот " + cat.name + ", у которого показатель " + cat.field + " будет " + Cat.condition + " чем у " + Cat.enemy);
        }
    }

    public class Cat
    {
        internal string name = "Боец";
        internal string value = "Value";
        internal string field = "magicPower";
        static internal string condition = "меньше";
        static internal string enemy = "противника";
        static internal string sample = "В";
    }
}