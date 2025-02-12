using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l9t17
{
    /*
     * Создайте публичный класс Dog, который должен содержать два публичных свойства: Id и Description, тип определите сами.
     * Создате публичный статический метод GetDogDictionary(), который должен:
     *      1) Принимать целое число в качестве параметра.
     *      2) Создавать словарь экземпляров класса Dog, в качестве ключа используя Id, а значения - ссылку на новый созданный экземпляр.
     *      3) Заполнить словарь созданными экземплярами класса Dog в количестве, равному значению принятого параметра. Все Id должны быть различными.
     * Переопределить для класса Dog метод ToString() таким образом, чтобы бы он выводил информацию об экземпляре класса в следующем формате:
     * "Я красивая собачка и мой id=XXX!", где ХХХ - значения параметра Id экземпляра класса Dog.
     * Внутри метода Main() создайте переменную, содержащую результат вызова метода GetDogDictionary(). Значение аргумента - считать с клавиатуры.
     * Выведите в консоль содержимое словаря (каждое значение с новой строки) следующем формате:
     * "ID:KEY , Content: VALUE", где key и value соответствующие значения словаря.
     * Если при вызове метода GetDogDictionary() было использовано отрицательное значение - метод должен вернуть пустую ссылку. 
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Console.Write("Введите количество собак: ");
            int count = Convert.ToInt32(Console.ReadLine());

            Dictionary<int, Dog> myDogs = Dog.GetDogDictionary(count);

            foreach (KeyValuePair<int, Dog> pair in myDogs)
            {
                Console.WriteLine($"ID:{pair.Key} , Content: {pair.Value}");
            }
        }
    }

    public class Dog
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public Dog(int Id)
        {
            this.Id = Id;
        }

        public static Dictionary<int, Dog> GetDogDictionary(int count)
        {
            Dictionary<int, Dog> DogDictionary = new Dictionary<int, Dog>();
            Random rand = new Random();

            int i = 0;
            while (i < count)
            {
                int tempId = rand.Next();

                if (DogDictionary.ContainsKey(tempId))
                    continue;

                DogDictionary[tempId] = new Dog(tempId);
                i++; 

            }
            
            return DogDictionary;
        }

        public override string ToString()
        {
            return $"Я красивая собачка и мой id={this.Id}";
        }
    }
}
