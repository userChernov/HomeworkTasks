using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l7t5
{
    /*
     * Создайте класс Cat с публичной статической переменной allCats. Реализуйте класс Cat таким образом,
     * чтобы при создании каждого экземпляра класса Cat, он попадал в переменную allCats.
     * Внутри метода Main() создайте 10 экземпляров класса Cat. Выведите на экран содержимое переменной
     * allCats, каждое значение с новой строки.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */

            Cat cat1 = new Cat();

            cat1.AddCat(cat1);
            Cat.PrintCat();

        }
    }
    /* Добавьте свой код ниже */
    public class Cat()
    {
        public static List<Cat> allCats;

        public void AddCat(Cat cat)
        {
            allCats.Add(cat);
        }

        public static void PrintCat()
        {
            List<Cat>.Enumerator it = Cat.allCats.GetEnumerator();
            while (it.MoveNext())
                Console.WriteLine(it.Current);

        }
    }

}

