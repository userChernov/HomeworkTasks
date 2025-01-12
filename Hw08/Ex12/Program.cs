using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace l8t12
{
    /*
     * Внутри метода Main() отсортируйте список экземпляров класса DogClient в порядке убывания. Критерии сортировки:
     *      1) По возрасту.
     *      2) Если возраст экземпляров равен, то они должны сортироваться между собой в порядке убывания их веса.
     *      3) Если возраст и вес равны, то они должны идти в том же порядке, в котором они добавлены в список.
     * Шаблон задачи изменять нельзя.
     */


    public class DogBank
    {
        public static List<DogClient> dogClientList = new List<DogClient>()
        {
            new DogClient("Барбос",1,5),
            new DogClient("Тризор",2,1),
            new DogClient("Ревизор",1,5),
            new DogClient("Терьер",2,5),
            new DogClient("Киллер",2,3),
            new DogClient("Бутч",3,7),
            new DogClient("Рекс",5,5),
        };


        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Console.Clear();

            for (int i = 0; i < dogClientList.Count; i++)
            {
                for (int j = 0; j < dogClientList.Count - i - 1; j++)
                {
                    if (dogClientList[j].Age > dogClientList[j + 1].Age)
                    {
                        TwoClientChange(j);
                    }
                    else if (dogClientList[j].Age == dogClientList[j+1].Age)
                    {
                        if (dogClientList[j].Weight < dogClientList[j+1].Weight)
                        {
                            TwoClientChange(j);
                        }
                        // else if (dogClientList[j].Weight == dogClientList[j + 1].Weight)
                    }
                }
            }

            for (int i = 0; i < dogClientList.Count; i++)
            {
                Console.WriteLine(dogClientList[i]);
            }

        }

        public static void TwoClientChange(int number)
        {
            DogClient tempClient = dogClientList[number];
            dogClientList[number] = dogClientList[number + 1];
            dogClientList[number + 1] = tempClient;
        }


    }


    public class DogClient
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Weight { get; set; }


        public DogClient(string name, int age, int weight)
        {
            Name = name;
            Age = age;
            Weight = weight;
        }


        public override string ToString()
        {
            return $"Я собачка {Name}! Мне {Age} лет и я вешу {Weight}!";
        }
    }
}
