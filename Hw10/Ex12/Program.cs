using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l10t12
{
    /*
     * Реализуйте метод Swapper(), который:
     *      1) Принимает большое целое число в качестве входящего параметра.
     *      2) Если принятое число состоит только из нулей и единиц, то преобразует число следующим образом: все нули становятся единицами, а единицы нулями.
     *      3) Если принятое число 0 или отрицательное, то возвращает ноль.
     *      4) Во всех остальных случаях возвращет число, записанное задом наперед.
     * ======================================================================================================================================================
     *      Пример: получил 0 - вернул 0;
     *      Пример: получил -100 - вернул 0;
     *      Пример: получил 10000101 - вернул 01111010;
     *      Пример: получил 123 - вернул 321;
     * ======================================================================================================================================================
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            
            string x = Console.ReadLine();
            
            string result = Swapper(x);

            Console.WriteLine($"Результат = {result}");

        }

        /* Добавьте свой код ниже */
        public static string Swapper(string a)
        {
            /* Добавьте свой код ниже */
            if (long.Parse(a) <= 0)
                return "0";

            bool isRotate = false;
            Stack<char> stack = new Stack<char>();
            string invert = "";
            string rotate = "";

            for (int i = 0; i < a.Length; i++)
            {
                int num = int.Parse(a[i].ToString());
                if (num > 1)
                {
                    isRotate = true;
                }

                if (a[i] == '1')
                    invert += '0';
                else  if (a[i] == '0')
                    invert += '1';

                stack.Push(a[i]);
            }

            if (isRotate)
            {
                while(stack.Count > 0)
                {
                    rotate += stack.Pop();
                }

                return rotate;
            }
            else return invert;

        }
    }
}

