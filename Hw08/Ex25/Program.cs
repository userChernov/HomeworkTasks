using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;


namespace l8t25
{
    /*
     * Реализуйте класс RichCat, добавив ему целочисленное автоматическое свойство Account, отвечающее за состояние счета экземпляра класса.
     * Добавьте классу RichCat конструктор, принимающий и устанавливающий значение свойства класса.
     * Создайте статический GetModNumber(), который принимает список экземпляров класса RichCat, а возвращает самое большое по модулю значение
     * свойства Account у принятых экземпляров класса.
     */


    public class RichCat
    {
        /* Добавьте свой код ниже */
        //private int account;
        public int Account { get; private set; }


        public static void Main(string[] args)
        {
            List<RichCat> cats = new List<RichCat>();
            Random rand = new Random();

            for (int i = 0; i < 10; i++)
            {
                cats.Add(new RichCat(rand.Next(1, 50)));
            }

            foreach (var item in cats)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            
            Console.WriteLine(GetModNumber(cats));

        }
        /* Добавьте свой код ниже */

        public RichCat(int money)
        {
            this.Account = money;
        }

        public static int GetModNumber(List<RichCat> cats)
        {
            int maxValue = 0;

            foreach (var item in cats)
            {  
                if (Math.Abs(item.Account) > maxValue)
                {
                    maxValue = item.Account;
                }
            }

            return maxValue;
        }

        public override string ToString()
        {
            return $"На счете {this.Account}";
        }

    }
}
