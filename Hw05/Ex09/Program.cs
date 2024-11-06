using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex09
{
    /*
     * Внутри класса Program создайте две публичных целочисленных переменных: id и count. Переменная id должна отвечать за уникальный
     * идентификатор экземпляра класса, а переменная count должна подсчитывать совокупное количество экземпляров класса.
     * Создайте конструктор для класса Program по умолчанию, который должен:
     *      1) Присваивать созданному экземпляру уникальное значение переменной id.
     *      2) Увеличивать счетчик количества экземпляров класса.
     */

    public class Program
    {
        /* Добавьте свой код ниже */
        public int id;
        public static int count = 0;
        private Random rand = new Random();

        public Program()
        {
            this.id = rand.Next();
            count ++;
            Console.WriteLine(count);
        }

        public static void Main(string[] args)
        {
            Program p1 = new Program();
            Program p2 = new Program();
            Program p3 = new Program();
            Program p4 = new Program();
            Program p5 = new Program();

            Console.WriteLine($"Итого {count}");
        }
    }
}
