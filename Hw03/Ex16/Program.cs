using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex16
{
    /*
     * Создайте класс Cat в том же namespace, что и класс Program.
     * Внутри класса Cat:
     *      1) Создайте 2 строковых поля с произвольными именами.
     *      2) Создайте 2 целочисленных поля с произвольными именами.
     *      3) 3 произвольных поля сделайте константами.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
        }
    }
    /* Добавьте свой код ниже */

    class Cat
    {
        string name;
        const string owner = "Игорь";
        const int age = 3;
        const int weight = 10;
    }
}