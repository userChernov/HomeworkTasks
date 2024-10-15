using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01
{
    /*
     * Проанализируйте приведенный код и определите, что должна делать программа.
     * Исправьте программу, чтобы она стала работать корректно.
     */
    public class Program
    {
        public static void Main(string[] args)
        {
            Human human = new Human();
            Console.WriteLine("Ваш текущий возраст: " + human.age);
            human.AddAge(human.age);
            Console.WriteLine("Прошло 20 лет... ");
            Console.WriteLine("Ваш текущий возраст: " + human.age);
        }
    }

    public class Human
    {
        public int age = 15;

        public void AddAge(int age)
        {
            this.age = this.age + 20;
            Console.WriteLine("Через 20 лет вам исполнится: " + this.age);
        }
    }
}
