using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ex06
{
    /*
     * Создайте новый класс Cat в том же файле и том же namespace, что и класс Program. 
     * В классе Cat создайте 6 переменных, имена, типы переменных и модификатор доступа переменных придумайте самостоятельно. 
     * Создайте 7 различных конструкторов для класса Cat.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
        }
    }

    public class Cat
    {
        public string name;
        public int age;
        //TODO Переименовать переменную на нормальную
        public string poroda;
        public string eyeColor;
        public string ownerName;
        public int ownerAge;

        public Cat(string name)
        {
            this.name = name;
        }
        public Cat(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public Cat(string name, int age, string poroda)
        {
            this.name = name;
            this.age = age;
            this.poroda = poroda;
        }
        public Cat(string name, int age, string poroda, string eyeColor)
        {
            this.name = name;
            this.age = age;
            this.poroda = poroda;
            this.eyeColor = eyeColor;
        }
        public Cat(string name, int age, string poroda, string eyeColor, string ownerName)
        {
            this.name = name;
            this.age = age;
            this.poroda = poroda;
            this.eyeColor = eyeColor;
            this.ownerName = ownerName;
        }
        public Cat(string name, int age, string poroda, string eyeColor, string ownerName, int ownerAge)
        {
            this.name = name;
            this.age = age;
            this.poroda = poroda;
            this.eyeColor = eyeColor;
            this.ownerName = ownerName;
            this.ownerAge = ownerAge;
        }
        public Cat(string name, string ownerName)
        {
            this.name = name;
            this.ownerName = ownerName;
        }
    }
}
