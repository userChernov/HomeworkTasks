using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l9t10
{
    /*
     * Создайте статический метод AllByZero(), который принимает целое число и выводит на экрана результат от деления принятого числа на ноль.
     * Внутри метода Main() вызовите метод AllByZero() и перехватите исключение. Выведите на экран стектрейс возникшего исключения.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Console.Clear();

            int a = 10;
            StackTrace currentStack = new StackTrace();

            try
            {
                AllByZero(a);
            }
            catch(Exception ex)
            {
                for (int i = 0; i < currentStack.FrameCount; i++)
                {
                    StackFrame stackFrame = currentStack.GetFrame(i);
                    Console.WriteLine(stackFrame.GetMethod().Name);

                }
            }
        }

        public static void AllByZero(int a)
        {
            Console.WriteLine(a / 0);
        }
    }
}
