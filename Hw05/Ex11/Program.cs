using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11
{
    /*
     * Для класса Dog добавьте следующие переменные:
     *      1) name - отвечающую за имя.
     *      2) speed - отвечающую за скорость.
     *      3) age  - отвечающую за возраст.
     *      4) weight - отвечающую за вес.
     *      5) dogCount - отвечающую за общее количество созданных экземпляров класса Dog.
     * Все переменные сделайте публичными, тип и остальные модификаторы определите самостоятельно.
     * Для класса Dog измените конструктор по умолчанию таким образом, чтобы он:
     *      1) Увеличивал общее количество созданных экземпляров.
     *      2) Присваивал значение равное 1 всем целочисленным переменным класса Dog, относящимся к экземпляру класса.
     */

    public class Dog
    {
        /* Добавьте свой код ниже */
        public string name;
        public int speed;
        public int age;
        public int weight;
        public static int dogCount = 0;

        public Dog()
        {
            dogCount ++;
            this.speed = 1;
            this.age = 1;
            this.weight = 1;
        }
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Dog dog1 = new Dog();
            Dog dog2 = new Dog();
            Dog dog3 = new Dog();
            Dog dog4 = new Dog();

            Console.WriteLine(Dog.dogCount);
        }
    }
}
