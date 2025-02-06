using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l9t26
{
    /*
     * Создайте статический метод GetRandomList, который принимает целое число X и возвращает список целых чисел длинной X,
     * заполненный случайными числами от 1 до 100. Внутри метода Main() сохраните результат вызова метода GetRandomList
     * в переменную соответствующего типа, после чего создайте новый стек (Stack), поместив в него все элементы полученного списка.
     * Аргумент при вызове считайте с консоли.
     * Выведите попарно элементы обоих списков (каждый с новой строки) в следующем формате:
     * "ХХХ – YYY", где ХХХ - элемент списка, YYY - элемент стека.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Console.Write("Введите количестов элементов: ");
            int x = Convert.ToInt32(Console.ReadLine());

            List<int> randomList = GetRandomList(x);

            Stack<int> stack = new Stack<int>();

            foreach (int item in randomList)
            {
                stack.Push(item);
            }

            foreach (int item in randomList)
            {
                Console.WriteLine($"{item} - {stack.Pop()}");
            }

        }

        /* Добавьте свой код ниже */

        public static List<int> GetRandomList(int x)
        {
            List<int> result = new List<int>();
            Random rand = new Random();

            for (int i = 0; i < x; i++)
                result.Add(rand.Next(1, 100));

            return result;
        }
    }
}
