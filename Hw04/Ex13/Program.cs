using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex13
{
    /*
     * Внутри метода Main() реализуйте следующую логику работы программы:
     *      1) Объявите 3 переменные и присвойте им значения, считанные с клавиатуры.
     *      2) Если среди введенных значений есть одинаковые, то необходимо вывести их на экран через пробел.
     *      3) Выведите в консоль фразу "Все разные", если все 3 переменные содержат различные значения.
     *      4) Если все 3 переменные одинаковые, то выведите их все в консоль через запятую.
     * Тип и имена переменных определите самостоятельно.
     */
    
    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 == num2 && num1 == num3)
                Console.WriteLine($"{num1}, {num2}, {num3}");
            else if (num1 != num2 && num1 != num3 && num2 != num3)
                Console.WriteLine("Все разные");
            else if (num1 == num2 || num1 == num3 || num2 == num3)
                Console.WriteLine($"{num1} {num2} {num3}");

        }
    }
}
