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

            for (int i = 0; i < 10; i++)
            {
                string surname;
                string name;

                Console.Write("Введите Фамилию: ");
                surname = Console.ReadLine();

                Console.Write("Введите Имя: ");
                name = Console.ReadLine();

                users.Add(surname, name);
            }

            GetStatistic(users);
        }

        public static List<string> GetStatistic(Dictionary<string, string> users)
        {
            List<string> names = new List<string>();
            List<string> statisticNames = new List<string>();

            foreach (var item in users)
                names.Add(item.Value);

            names.Sort();

            int count = 1;

            for (int i = 0; i < names.Count - 1; i++)
            {
                if ( Equals(names[i], names[i+1]) )
                    count++;
                else
                {
                    statisticNames.Add($"{names[i]} - {count} повторений");
                    count = 1;
                }
            }

            foreach (var item in statisticNames)
            {
                Console.WriteLine(item);
            }

            return statisticNames;
        }
    }
}

