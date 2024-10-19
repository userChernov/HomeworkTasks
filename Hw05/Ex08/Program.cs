using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex08
{
    /*
     * Постарайтесь создать для класса Cat как можно больше конструкторов.
     * Шаблон задачи менять нельзя.
     */

    public class Cat
    {
        int age;
        int weight;
        string color;
        string name;
        /* Добавьте свой код ниже */

        //ВСЕГО 13 (12) конструкторов
        
        // Конструктор по умолчанию (1)
        public Cat()
        {
        }

        // Конструкторы с одной переменной (2)
        public Cat(int age)
        {
            this.age = age;
        }
        public Cat(string name)
        {
            this.name = name;
        }

        // Конструкторы с двумя переменными (4)
        public Cat(int age, int weight)
        {
            this.age = age;
            this.weight = weight;
        }
        public Cat(int age, string color)
        {
            this.age = age;
            this.color = color;
        }
        public Cat(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public Cat(string name, string color)
        {
            this.name = name;
            this.color = color;
        }

        // Конструкторы с тремя переменными (5) (один дублирующийся по составу переменных)
        public Cat(int age, int weight, string color)
        {
            this.age = age;
            this.weight = weight;
            this.color = color;
        }
        public Cat(int age, string name, int weight)
        {
            this.age = age;
            this.name = name;
            this.weight = weight;
        }
        public Cat(string name, int age, int weight)
        {
            this.name = name;
            this.age = age;
            this.weight = weight;
        }
        public Cat(string name, int weight, string color)
        {
            this.name = name;
            this.weight = weight;
            this.color = color;
        }
        public Cat(string name, string color, int age)
        {
            this.name = name;
            this.color = color;
            this.age = age;
        }

        // Конструктор с четыремя переменными (1)
        public Cat(int age, int weight, string name, string color)
        {
            this.age = age;
            this.weight = weight;
            this.name = name;
            this.color = color;
        }


        public static void Main(string[] args)
        {
        }
    }
}
