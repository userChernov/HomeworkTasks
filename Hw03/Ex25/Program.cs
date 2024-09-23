using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex25
{
    /*
     * Внутри класса Cat:
     *      1) Создайте два поля: name и age, доступные из любой точки программы.
     *      2) Создайте два поля: count и speed, доступные в пределах класса.
     *      3) Создайте два статических поля: magicPower и profession, доступные только для производных классов.
     * Типы созданных полей класса должны быть определены самостоятельно.
     */

    public class Cat
    {
        public string name;
        public int age;
        protected int count;
        protected int speed;
        static protected string magicPower;
        static protected string profession;        

        public static void Main(string[] args)
        {
        }
    }
}