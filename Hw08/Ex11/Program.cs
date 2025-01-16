using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace l8t11
{
    /*
     * Проанализируйте шаблон. Смоделируем ситуацию, когда банк решил подчистить ряды своих клиентов,
     * и убрать всех, чей счет не удовлетворяет их условиям. Дополните метод Main() так, чтобы получилась
     * моделируемая ситуация. Шаблон задачи изменять нельзя.
     */


    public class Program
    {
        static Random r = new Random();

        public static void Main(string[] args)
        {
            Console.Clear();

            for (int i = 0; i < 100; i++)
            {
                PrivateDogBank.clients.Add(new BusinessCat(r.Next(200, 701)));
            }
            /* Добавьте свой код ниже */

            PrivateDogBank.clients.RemoveWhere(cat => cat.Money < PrivateDogBank.Condition);

            HashSet<BusinessCat> listToRemove = new HashSet<BusinessCat>();
            //HashSet<BusinessCat> listToRemove = PrivateDogBank.clients.Where(cat => cat.Money < PrivateDogBank.Condition).ToHashSet();
            
            foreach (var item in PrivateDogBank.clients)
            {
                if (item.Money >= PrivateDogBank.Condition)
                    listToRemove.Add(item);
            }

            PrivateDogBank.clients = listToRemove;

            // foreach (var item in listToRemove)
            // {
            //     PrivateDogBank.clients.Remove(item);
            // }


            foreach (var item in PrivateDogBank.clients)
            {
                Console.WriteLine(item);
            }
        }
    }


    public static class PrivateDogBank
    {
        public static int Condition { get; set; } = 400;
        public static HashSet<BusinessCat> clients = new HashSet<BusinessCat>();
    }


    public class BusinessCat
    {
        private int money;

        public int Money => money;
        

        public BusinessCat(int money)
        {
            this.money = money;
        }


        public override string ToString()
        {
            return $"Я кот и на моём счету: {money}";
        }
    }
}
