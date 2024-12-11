using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l7t3
{
    /*
     * На вход в метод Main() будет подан массив строк args, каждая из строк будет содержать число типа double в строковом представлении, с различным количеством знаков после точки.
     * Создайте статический метод SmartCutter() который принимает массив строк и возвращает динамический массив, содержащий только те числа double из принятого массива, 
     * в которых количество знаков после точки меньше либо равно 3. 
     * Внутри метода Main() выведите результат работы метода SmartCutter() в консоль, каждый элемент с новой строки.
     */

    public class Program
    {
        //public static void Main(string[] args)
        public static void Main()
        {
            /* Добавьте свой код ниже */
            string[] arrs = new string[] { "13,456", "23,01", "22,2342",  "1,000001"};

            ArrayList arr = new ArrayList();
            arr = SmartCutter(arrs);

            for (int i = 0; i < arr.Count; i++)
            {
                Console.WriteLine(arr[i]);
            }

        }

        public static ArrayList SmartCutter(string[] array)
        {
            int dotIndex;
            string symbol;
            string value;
            ArrayList returnArray = new ArrayList();
            
            for (int i = 0; i < array.Length; i++)
            {
                symbol = array[i];
                dotIndex = array[i].IndexOf(',');
                if (symbol.Length - dotIndex <= 4)
                      returnArray.Add(double.Parse(array[i]));
            }

            return returnArray;
        }
    }
}

