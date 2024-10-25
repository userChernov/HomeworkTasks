using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex13
{
    /*
     * Реализуйте класс Dog таким образом, чтобы он мог инициализироваться при помощи следующих конструкторов:
     *      1) Имя.
     *      2) Имя, вес и возраст.
     *      3) Имя и возраст.
     *      4) Вес, цвет.
     *      5) Вес, цвет и адрес.
     * Защитите класс Dog от создания "бесполезных" экземпляров класса, определите обязательные значения и 
     * инициализируйте их произвольными значениями в каждом из созданных конструкторов.
     * Все элементы класса должны быть публичными.
     */

    public class Dog
    {
        public string name = "Rex";
        public int weight = 2;
        public int age = 1;
        public string color = "black";
        public string address = "London";

        public Dog(string name)
        {
            this.name = name;
        }
        public Dog(string name, int weight, int age)
        {
            this.name = name;
            this.weight = weight;
            this.age = age;
        }
        public Dog(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public Dog(int weight, string color)
        {
            this.weight = weight;
            this.color = color;
        }
        public Dog(int weight, string color, string addres)
        {
            this.weight = weight;
            this.color = color;
            this.address = addres;
        }



        /* Добавьте свой код ниже */
        public static void Main(string[] args)
        {
        }
    }
   
}
