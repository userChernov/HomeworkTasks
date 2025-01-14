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
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */

            int wallet = 500;
            int getMoney = 300;
            int setMoney = 198;
            int cash = 0;
            bool isCanGetmoney = true;
            
            while (isCanGetmoney)
            {
                if (wallet >= getMoney && wallet > 0)
                {
                    wallet -= getMoney;
                    cash += getMoney;

                    Console.WriteLine($"Wallet = {wallet}; Cash = {cash}");
                }
                else if (cash > setMoney && wallet > 0)
                {
                    wallet += setMoney;
                    cash -= setMoney;
                    Console.WriteLine($"Wallet = {wallet}; Cash = {cash}");
                }
                else isCanGetmoney = false;
            }

            Console.WriteLine(cash);
        }
    }
}
