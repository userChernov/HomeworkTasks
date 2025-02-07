using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l7t18
{
    /*
     * Добавьте публичную статическую переменную users, которая хранит в себе информацию о пользователях в формате "фамилия-имя"
     * в класс Program, тип переменной определяете самостоятельно.
     * В методе Main() заполните переменную users 10 значениями введенными с клавиатуры. Создайте публичный статический метод
     * GetStatistic, который:
     *      1) Принимает в качестве входящего параметра тип переменной users.
     *      2) Возвращает список строк, который содержит список всех имён из users и указывает количество их повторений в users в формате
     * "NAME - ХХХ повторений", где NAME имя из users, а ХХХ - количество повторений имени NAME в users.
     * Внутри метода Main() выведите результат работы метода GetStatistic(), каждое значение с новой строки.
     */

    public class Program
    {
        /* Добавьте свой код ниже */

        public static Dictionary<string, string> users = new Dictionary<string, string>();

        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */

            for (int i = 0; i < 5; i++)
            {
                string surname;
                string name;

                Console.Write("Введите Фамилию: ");
                surname = Console.ReadLine();

                Console.Write("Введите Имя: ");
                name = Console.ReadLine();

                users.Add(surname, name);
            }


            List<string> result = GetStatistic(users);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        public static List<string> GetStatistic(Dictionary<string, string> users)
        {
            Dictionary<string, int> namesCount = new Dictionary<string, int>();

            foreach (KeyValuePair<string, string> entry in users)
            {
                string name = entry.Value;

                if (namesCount.Keys.Contains(name)) 
                {
                    namesCount[name]++;
                }
                else 
                {
                    namesCount[name] = 1;
                }
            }

            List<string> statisticNames = new List<string>();

            foreach (KeyValuePair<string, int> item in namesCount)
            {
                statisticNames.Add($"{item.Key} - {item.Value} повторений");
            }

            return statisticNames;
        }
    }
}