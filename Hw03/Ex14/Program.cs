using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex14
{
    /*
     * Создайте новый класс Ovcharka в том же файле и том же namespace, что и класс Program. 
     * Объявите в классе Ovcharka три целочисленные переменные: age, weight, legsCount. Объявите 
     * в классе Ovcharka две переменные типа строка: name, breed. Подумайте, какие из перечисленных 
     * элементов логично сделать константами, сделайте их константами и присвойте им какие-нибудь 
     * значения по умолчанию.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
        }
    }

    class Ovcharka
    {
        int age;
        int weight;
        const int legsCount = 4;
        string name;

        /*Не смог определиться!
        С одной стороны овчарка - это и есть порода
        а с другой стороны, тут может подразумеваться "Немецкая", "Бельгийская" итд*/
        const string breed = "sheepdog";
        //string breed; 

    }
}