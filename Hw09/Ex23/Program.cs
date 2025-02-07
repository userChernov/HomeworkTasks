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
            bool isZero = true;
            bool isIncorrect = true;
            int a = 0;
            int b = 0;
            string data = "0123456789";

            Console.Clear();
            Console.Write("Введите первое число: ");

            while (isIncorrect)
            {
                bool dataContains = true;
                string s = Console.ReadLine();

                for (int i = 0; i < s.Length; i++)
                {
                    if (!data.Contains(s[i]))
                    {
                        dataContains = false;
                        break;
                    }
                }

                if (dataContains)
                {
                    a = Convert.ToInt32(s);
                    isIncorrect = false;
                }
                else
                {
                    Console.Write("Введенное значение не является числом. Пожалуйста введите число: ");
                }

            }
           
            isIncorrect = true;
            Console.Write("Введите второе число: ");



            while (isZero)
            {
                b = Convert.ToInt32(Console.ReadLine());
                
                if (b != 0)
                    isZero = false;
                else
                    Console.Write("Делить на ноль НЕЛЬЗЯ!!! Пожалуйста введите другое число: ");
            }


            Console.WriteLine(DivisionBy(a, b));
        }

        public static int DivisionBy(int a, int b)
        {
            /* Добавьте свой код ниже */
            return a / b;
        }

    }
}
