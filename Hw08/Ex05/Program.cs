using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace l8t5
{
    /*
     * Реализуйте публичный класс CreditCard, который должен:
     *      1) Содержать публичное целочисленное свойство DollarsCount.
     *      2) Содержать публичное целочисленное свойство CentsCount.
     *      3) Конструктор класса, который принимает 1 число с плавающей запятой, где целая часть - количество долларов, а
     * дробная часть - количество центов на счете и устанавливает соответствующие значения свойствам класса.
     * Если переданное число имеет больше 2-х значимых чисел после запятой - его необходимо округлить до двух знаков после запятой.
     * Добавьте классу CreditCard статический метод CardInfo(), который:
     *      1) Принимает экземпляр класса CreditCard.
     *      2) Ничего не возвращает.
     *      3) Выводит в консоль информацию о состоянии текущего баланса в формате: "На карте мистера Кота ХХХ долларов и YYY центов".
     */


    public class CreditCard
    {
        /* Добавьте свой код ниже */
        public int DollarsCount { get; set; }
        public int CentsCount { get; set; }

        public CreditCard(double money)
        {
            money = Math.Round(money, 2);
            DollarsCount = Convert.ToInt32(money);
            CentsCount = Convert.ToInt32((money - DollarsCount) * 100);
        }

        public static void CardInfo(CreditCard myData)
        {
            Console.WriteLine($"На карте мистера Кота {myData.DollarsCount} долларов и {myData.CentsCount} центов");
        }

        public static void Main(string[] args)
        {
            Console.Write("Введите сумму: ");
            double money = Convert.ToDouble(Console.ReadLine());
            CreditCard cardMoney = new CreditCard(money);

            CardInfo(cardMoney);
        }
    }
}
