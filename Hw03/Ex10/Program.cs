using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10
{
    /*
     * Внутри метода Main() объявите 2 переменные класса Frog: frog1 и frog2, после чего присвойте им два экземпляра класса Frog.
     * Выведите на экран значения переменных frog1 и frog2, каждое с новой строки.
     * Шаблон задачи изменять нельзя.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            Frog frog1 = new Frog();
            Frog frog2 = new Frog();

            Console.WriteLine(frog1);
            Console.WriteLine(frog2);
        }
    }

    public class Frog
    {
        int id;
        public static object locker = new object();
        public static Random r = new Random();

        public Frog()
        {
            lock (locker)
            {
                this.id = r.Next(100);
            }
        }

        public override string ToString()
        {
            return "Лягушка " + this.id + " говорит ква-ква!";
        }
    }
}