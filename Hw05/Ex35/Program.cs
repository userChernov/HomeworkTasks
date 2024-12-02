using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex35
{
    /*
     * Реализуйте перечисление MyFavoritePets, которое должно содержать как минимум 4 элемента, 
     * каждый из которых должен олицетворять названия ваших любимых домашних животных.
     * Реализуйте класс Animal, который должен содержать:
     *      1) Четыре поля класса: возраст, вес, скорость и тип.
     *      2) 1 конструктор, который принимает только тип животного.
     * Конструктор класса, должен инициализировать все недостающие поля класса, на основе переданного типа.
     * Все инициализированные в конструкторе поля класса должны иметь значения, отличные от значений по умолчанию.
     * Все элементы класса должны быть публичными.
     */
    public class Animal
    {
        public int age;
        public int weight;
        public int speed;
        public MyFavoritePets type;

        public Animal(MyFavoritePets type)
        {
            int num = Convert.ToInt32(type);
            switch (num)
            {
                case 0:
                {
                    this.age = 7;
                    this.weight = 3;
                    this.speed = 6;
                    break;
                }
                case 1:
                {
                    this.age = 3;
                    this.weight = 10;
                    this.speed = 9;
                    break;
                }
                case 2:
                {
                    this.age = 30;
                    this.weight = 150;
                    this.speed = 1;
                    break;
                }
                case 3:
                {
                    this.age = 1;
                    this.weight = 1;
                    this.speed = 2;
                    break;
                }
                default:
                {
                    break;
                }
            }
        }


        /* Добавьте свой код ниже */
        public static void Main(string[] args)
        {            
        }
    }

    public enum MyFavoritePets
    {
        /* Добавьте свой код ниже */
        Cat,
        Dog,
        Elephant,
        Hamster
    }
}
