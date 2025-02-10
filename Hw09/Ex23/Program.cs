using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l9t23
{
    /*
     * Реализуйте статический метод DivisionBy(), который принимает два целых числа и возвращает результат деления первого на второе.
     * Внутри метода Main() вызовите метод DivisionBy(), передав ему в качестве аргумента два числа, введенные с клавиатуры.
     * Реализуйте запрос ввода чисел с клавиатуры таким образом, чтобы в случае если второе введенное число было равно нулю, то:
     *      1) На экран выводилась фраза "Делить на ноль НЕЛЬЗЯ!!! Пожалуйста введите другое число".
     *      2) Повторяли считывание второго числа до тех пор, пока не будет введено корректное значение.
     * Если на любом из этапов ввода было введено некорректное значение, которое приведет к возникновению исключения, необходимо:
     *      1) На экран выводилась фраза "Введенное значение не является числом. Пожалуйста введите число".
     *      2) Повторяли считывание числа до тех пор, пока не будет введено корректное значение.
     * Шаблон задачи изменять нельзя.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Console.Clear();
            int a;
            int b;

            Console.Write("Введите первое число: ");
            while (true)
            {
                string s = Console.ReadLine();

                if (!Int32.TryParse(s, out a))
                    Console.Write("Введенное значение не является числом. Пожалуйста введите число: ");
                else
                    break;
            }

            Console.Write("Введите второе число: ");
            while (true)
            {
                string s = Console.ReadLine();

                if (!Int32.TryParse(s, out b))
                    Console.Write("Введенное значение не является числом. Пожалуйста введите число: ");
                else if (b == 0)
                    Console.Write("Делить на ноль НЕЛЬЗЯ!!! Пожалуйста введите другое число: ");
                else
                    break;
            }

            Console.WriteLine($"a / b = {DivisionBy(a, b)}");
        }

        public static int DivisionBy(int a, int b)
        {
            /* Добавьте свой код ниже */
            return a / b;
        }
    }
}
