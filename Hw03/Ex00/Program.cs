using System;

namespace Ex00
{
    class Cat
    {
        public string Name;
        public int Age;
        public string Color;

        public void DoMeow()
        {
            Console.WriteLine("Meoooow");
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Кота зовут {Name}");
            Console.WriteLine($"Его возраст {Age}");
            Console.WriteLine($"Его цвет {Color}");
        }

        public static Cat CreateKitten()
        {
            Cat cat1 = new Cat();
            
            cat1.Name = "Kitten";
            cat1.Age = 1;
            cat1.Color = "black";
            
            return cat1;
        }
    }

    class Program
    {
        static void Main()
        {
            Cat cat1 = new Cat();
            cat1.Name = "Barsic";
            cat1.Age = 2;
            cat1.Color = "Gray";
            
            cat1.DoMeow();
            cat1.ShowInfo();

            Cat newCat = Cat.CreateKitten();

            newCat.ShowInfo();
        }
    }
}


