using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02
{
    /*
     * Проанализируйте шаблон и определите, что должна делать программа.
     * Реализуйте метод SheepCalculator(), который при каждом вызове должен:
     *   1) Увеличивать на единицу значение параметра sheepCount.
     *   2) Подсчитывать общую стоимость всех созданных овец.
     * Остальные данные исходного шаблона изменять нельзя.
     * Метод Main() должен вывести в консоль число созданных овец и их суммарную стоимость.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                new Sheep().SheepCalculator(i * 100);
            }
            Console.WriteLine("Количество пробегавших овечек: " + Sheep.sheepCount + "...");
            Console.WriteLine("А их суммарная стоимость: " + Sheep.sheepPrice + " условных единиц!");
        }

        public class Sheep
        {
            public static int sheepCount = 0;
            public static int sheepPrice = 0;

            public void SheepCalculator(int sheepPrice)
            {
                /* Добавьте свой код ниже */
                sheepCount ++;
                Sheep.sheepPrice += sheepPrice;

            }
        }
    }
}
