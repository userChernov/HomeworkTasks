using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex07
{
    /*
     * Реализуйте класс Rectangle, который содержит четыре целочисленные переменные - координаты Х вершин прямоугольника.
     * Создайте 5 конструкторов для класса Rectangle.
     */
    public class Rectangle
    {
        /* Добавьте свой код ниже */
        public int first;
        public int second;
        public int third;
        public int fourth;

        public Rectangle()
        {
            
        }
        public Rectangle(int first)
        {
            this.first = first;
        }
        public Rectangle(int first, int second)
        {
            this.first = first;
            this.second = second;
        }
        public Rectangle(int first, int second, int third)
        {
            this.first = first;
            this.second = second;
            this.third = third;
        }
        public Rectangle(int first, int second, int third, int fourth)
        {
            this.first = first;
            this.second = second;
            this.third = third;
            this.fourth = fourth;
        }

        public static void Main(string[] args)
        {
        }
    }
}
