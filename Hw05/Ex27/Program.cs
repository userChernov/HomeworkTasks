using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex27
{
    /*
     * Реализуйте класс Cat, добавив ему целочисленное поле id.
     * Создайте для класса Cat конструктор, который принимает параметр id и выводит в консоль сообщение в формате:
     * "Привет привет котику с id: XXX", где ХХХ - id созданного экземпляра класса, переданный ему при вызове конструктора.
     * Создайте деструктор класса Cat и измените его таким образом, чтобы при обращении к нему на экран выводилась фраза:
     * "Пока пока котик с id: ХХХ", где ХХХ - id уничтожаемого экземпляра класса. 
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            Random rand = new Random();

            
            for (int i = 0; i < 10; i++)
            {
                Cat cat = new Cat(i);
                Console.WriteLine($"Привет привет котику с id: {cat.id}");
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();


        }
    }

    public class Cat
    {
        /* Добавьте свой код ниже */
        public int id;

        public Cat(int id)
        {
            this.id = id;
        }

        ~Cat()
        {
            Console.WriteLine($"Пока пока котику с id: {this.id}");

        }
    }
}
