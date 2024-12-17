using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l7t9
{
    /*
     * Внутри метода Main() создайте новую переменную и присвойте ей словарь, со строковым типом ключа и значения.
     * Добавьте в словарь 5 ваших любимых игрушек из детства и дайте их краткое описание. Выведите на экран
     * содержимое словаря в следующем формате:
     * "Мою игрушку зовут KEY и это: VALUE", где KEY и VALUE это соответствующие элементы словаря.
     * Метод Main() не должен ничего считывать с клавиатуры.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */

            Dictionary<string, string> myToys = new Dictionary<string, string>();

            myToys.Add("Ти Рекс", "Динозавр");
            myToys.Add("Желтая машинка", "Феррари");
            myToys.Add("Футбольный мяч", "Мяч");
            myToys.Add("Тетрис", "Приставка");
            myToys.Add("Кубик-рубика", "Головоломка");

            foreach (var item in myToys)
                Console.WriteLine($"Мою игрушку зовут {item.Key} и это: {item.Value}");
                
        }
    }
}

