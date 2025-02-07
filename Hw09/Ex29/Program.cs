using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l9t29
{
    /*
     * Внутри класс Program создайте статический метод GetClientList(), который:
     *      1) Принимает стек экземпляров класса DogClient и стек экземпляров класса CatClient.
     *      2) Возвращает типизированный стек, содержащий экземлпяры классов DogClient и CatClient расположенные через одного.
     *      3) Если стек экземпляров классов DogClient больше стека CatClient на 1 или равен ему, то верхним элементом
     *      возвращаемого стека должен являться экземпляр класса DogClient.
     *      4) Если стек экземпляров классов DogClient меньше стека CatClient на 1, то верхним элементом
     *      возвращаемого стека должен являться экземпляр класса CatClient.
     *      5) Если разница в количестве элементов стеков экземпляров класса DogClient и CatClient больше 2, то
     *      метод должен вернуть null.
     * Шаблон задачи изменять нельзя.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
        }
        /* Добавьте свой код ниже */

    }

    public class DogClient
    {
        public override string ToString()
        {
            return "Клиент собачка";
        }
    }

    public class CatClient
    {
        public override string ToString()
        {
            return "Клиент котик";
        }
    }
}
