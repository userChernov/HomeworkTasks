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
        public int count = 0;
        private Random rand = new Random();

        public Program()
        {
            this.id = rand.Next();
            this.count ++;
        }

        public static void Main(string[] args) { }
    }
}
