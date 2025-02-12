using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace l8t7
{
    /*
     * Внутри метода Main() отсортируйте коллекцию экземпляров класса BusinessCat так, чтобы они шли 
     * в порядке убывания их баланса на кредитной карте. Шаблон задачи изменять нельзя.
     */


    public class Program
    {
        public static List<BusinessCat> richCatsList = new List<BusinessCat>()
        {
            new BusinessCat(),
            new BusinessCat(),
            new BusinessCat(),
            new BusinessCat(),
            new BusinessCat(),
            new BusinessCat(),
            new BusinessCat()
        };


        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */

            for (int i = 0; i < richCatsList.Count; i++)
            {
                for (int j = 0; j< richCatsList.Count - i - 1; j++)
                {
                    if (richCatsList[j].CardBalance < richCatsList[j + 1].CardBalance)
                    {
                        BusinessCat temp = richCatsList[j];
                        richCatsList[j] = richCatsList[j + 1];
                        richCatsList[j + 1] = temp;
                    }
                }
            }

            for (int i = 0; i < richCatsList.Count; i++)
            {
                Console.WriteLine(richCatsList[i].CardBalance);
            }
        }
    }


    public class BusinessCat
    {
        private static Random r = new Random();
        public int CardBalance { get; private set; }


        public BusinessCat()
        {
            CardBalance = r.Next(-1000, 1000);
        }
    }
}
