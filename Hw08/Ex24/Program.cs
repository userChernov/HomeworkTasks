using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace l8t24
{
    /*
     * Клиенты банка PrivateCatBank столкнулись со странным ограничением на совершение операций со своими счетами.
     * Они могут снимать со счета 300 монеток и пополнять свой счет на 198 монеток.
     * Внутри метода Main() реализуйте логику работы программы, которая поможет определить какую максимальную сумму
     * сможет снять клиент данного банка, если его текущий баланс - 500 монеток. Выведите на экран получившееся значение.
     */

     /*


     */


    public class PrivateCatBank
    {
            public static int wallet = 500;
            public static int getMoney = 300;
            public static int setMoney = 198;
            public static int cash = 0;
            public static bool isCanGetmoney = true;

            public static int combo1 = 300;
            public static bool c1 = true;

            public static int combo2 = 198;
            public static bool c2 = true;

            public static int combo3Reload = +198+198;
            public static int testTick = 0;


        public static void Main(string[] args)
        {
            
            /* Добавьте свой код ниже */

            while (testTick < 300)
            {
                Combo1();
                Combo2();
                testTick++;
            }

        }

        public static void Combo1()
        {
            if (wallet >= combo1)
            {
                wallet -= combo1;
                cash += combo1;
                Console.WriteLine($"# = {testTick};     Wallet = {wallet};     Cash = {cash}     -300");
            }
        }

        public static void Combo2()
        {
            if (cash >= combo2)
            {
                cash -= combo2;
                wallet += combo2;
                Console.WriteLine($"# = {testTick};     Wallet = {wallet};     Cash = {cash}     +198");
            }
        }



    }
}
