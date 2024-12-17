using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l7t17
{
    /*
     * Внутри метода Main() необходимо заполнить словарь personsInDaClub экземплярами класса Person, в качестве ключа
     * необходимо использовать порядковые номера, начиная с единицы. Словарь необходимо заполнять до тех пор, пока в
     * нём не появится 15 посетителей, которые бы полностью удовлетворяли всем условиям фейсконтроля.
     * Создайте публичный статический метод FaceControl, который принимает экземпляр класса Person и возвращает
     * результат проверки. Логика проверки должна учитывать:
     *      1) Никаких посетителей моложе 18.
     *      2) Никаких посетителей у кого менее 250 наличных в кармане.
     * Шаблон задачи изменять нельзя.
     */

    public class FashionClub
    {
        public static Dictionary<int, Person> personsInDaClub = new Dictionary<int, Person>();

        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */

            int count = 1;
            while (count <= 15)
            {
                Person person = new Person();

                if (FaceControl(person))
                {
                    personsInDaClub.Add(count, person);
                    count++;
                }
            }

            foreach (var item in personsInDaClub)
                Console.WriteLine($"{item.Key}_{item.Value.Age}_{item.Value.Cash}");
        }

        public static bool FaceControl(Person person)
        {
            bool isFaseControlResult = false;

            if (person.Age < 18 || person.Cash < 250)
                isFaseControlResult = false;
            else isFaseControlResult = true;

            return isFaseControlResult;
        }
    }

    public class Person
    {
        static Random r = new Random();
        public int Age { get; private set; }
        public int Cash { get; private set; }

        public Person()
        {
            Age = r.Next(10, 36);
            Cash = r.Next(100, 1001);
        }
    }
}

