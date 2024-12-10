using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l6t13
{
    /*
     * Создайте статический метод GetDistance(), который должен вычислять и возвращать расстояние между двумя точками на координатной плоскости.
     * Метод должен принимать X1 и Y1 - координаты первой точки, а также X2 и Y2 - координаты второй точки.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Console.Write("Введите координату X1: ");
            double x1 = double.Parse(Console.ReadLine());

            Console.Write("Введите координату Y1: ");
            double y1 = double.Parse(Console.ReadLine());

            Console.Write("Введите координату X2: ");
            double x2 = double.Parse(Console.ReadLine());

            Console.Write("Введите координату Y2: ");
            double y2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"Расстояние между координатами равно: {GetDistance(x1, y1, x2, y2)}");
        }

        public static double GetDistance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt( Math.Pow((x2-x1), 2) - Math.Pow((y2-y1), 2) );
        }

    }
}
