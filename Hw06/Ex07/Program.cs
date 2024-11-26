using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace l6t7
{
    /*
     * Создайте новую структуру Circle в том же файле и том же namespace, что и класс Program.
     * Структура должна содержать в себе следующие важные элементы:
     *      1) x,y - координаты центра окружности.
     *      2) r - радиус окружности.
     *      3) color - цвет линии окружности.
     * Создайте 3 конструктора для структуры Circle:
     *      1) Координаты центра окружности.
     *      2) Радиус.
     *      3) Цвет линии окружности
     * Если координаты центра окружности не заданы, то она должна находится в точке 2 2 координатной сетки.
     * Возможный шаг по координатной плоскости - целочисленный, радиус по умолчанию 1.
     * Дробный, отрицательный и нулевой радиус недопустимы. Цвет по умолчанию  - любой.
     * Все элементы структуры должны быть доступны за пределами самой структуры.
     */

    public class Program
    {
        public static void Main(string[] args)
        {

        }
    }

    /* Добавьте свой код ниже */

    public struct Circle
    {
        public int x;
        public int y;
        public int r;
        public string color;

        public Circle(int x, int y)
        {
            this.x = x;
            this.y = y;

            this.r = 1;
            this.color = "cyan";
        }

        public Circle(int r)
        {
            this.x = 2;
            this.y = 2;

            if (r > 0)
                this.r = r;

            this.color = "cyan";
            
        }

        public Circle(string color)
        {
            this.x = 2;
            this.y = 2;

            this.r = 1;

            this.color = color;
        }

    }
}
