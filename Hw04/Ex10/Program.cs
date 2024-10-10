using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10
{
    /*
     * Внутри метода Main() реализуйте следующую логику работы программы:
     *  1) Считайте с консоли число.
     *  2) Если число положительное, то увеличьте его в 7 раз и выведите его в консоль, в следующем формате:
     *     "Число положительное, и после преобразования оно станет равным: ХХХ".
     *  3) Если число отрицательное, то прибавьте к нему 7 и выведите его в консоль, в следующем формате:
     *     "Число отрицательное, и после преобразования оно станет равным: ХХХ".
     *     ХХХ - введённое число, после преобразования.
     *  4) Если введён ноль, то необходимо просто вывести его в консоль.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            int num = Convert.ToInt32(Console.ReadLine());

            if (num > 0)
            {
                num *= 7;
                Console.WriteLine($"Число положительное, и после преобразования оно станет равным: {num}");    
            }
            else if (num < 0)
            {
                num += 7;
                Console.WriteLine($"Число отрицательное, и после преобразования оно станет равным: {num}");        
            }
            else
            {
                Console.WriteLine(num);   
            }
        }
    }
}
