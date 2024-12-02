using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04
{
    /*
     * Реализуйте метод SetName() в классе Dog, чтобы пример работал корректно и программа скомпилировалась,
     * остальные данные исходного шаблона изменять нельзя.
     */
    public class Dog
    {
        private string name;

        public static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.SetName("Барбос");
            Console.WriteLine(dog.name);
        }

        public void SetName(string name)
        {
            /* Добавьте свой код ниже */
            this.name = name;

        }
    }
}
