using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex34
{
    /*
     * Создайте перечисление AllPlaces в том же namespace, что и класс Program.
     * Перечисление должно содержать 3 элемента: First, Second, Third. Начальный индекс первого элемента должен начинаться с 1.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
        }
    }
    /* Добавьте свой код ниже */

    enum AllPlaces
    {
        First = 1,
        Second,
        Third
    }

}
