using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l9t3
{
    /*
     * Внутри класса Program создано 5 статических методов. Сделайте так, чтобы они вызывали друг друга по цепочке:
     *      1) Метод Main() вызывает метод ChainMethod4().
     *      2) Метод ChainMethod4() вызывает метод ChainMethod3().
     *      3) Метод ChainMethod3() вызывает метод ChainMethod2().
     *      4) Метод ChainMethod2() вызывает метод ChainMethod1().
     *      5) Метод ChainMethod1() вызывает метод ChainMethod().
     * Выведите на экран информацию о том, какой метод кого вызывает, начиная с метода Main() и до конца цепочки вызова. Формат вывода:
     * "Привет! Я метод - ХХХ и я вызываю метод - ХХХ", где ХХХ - имя метода из кадра стека.
     * Для последнего метода в цепочке (метод, который уже никого не вызывает) формат вывода должен быть следующий:
     * "Привет! Я метод - ХХХ и я никого не вызываю, я последний в цепочке вызова!"
     * Шаблон задачи изменять нельзя.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            ChainMethod4();
        }

        public static void ChainMethod4()
        {
            /* Добавьте свой код ниже */
            ChainMethod3();
        }

        public static void ChainMethod3()
        {
            /* Добавьте свой код ниже */
            ChainMethod2();
        }

        public static void ChainMethod2()
        {
            /* Добавьте свой код ниже */
            ChainMethod1();
        }

        public static void ChainMethod1()
        {
            /* Добавьте свой код ниже */
            ChainMethod();
        }

        public static void ChainMethod()
        {
            /* Добавьте свой код ниже */
            Console.Clear();

            StackTrace currentStack = new StackTrace();

            int i = currentStack.FrameCount - 1;
            while (i >= 0)
            {
                StackFrame currentFrame = currentStack.GetFrame(i);
                
                if (i > 0)
                {
                    StackFrame nextFrame = currentStack.GetFrame(i - 1);
                    Console.WriteLine($"Привет! Я метод - {currentFrame.GetMethod().Name} и я вызываю метод - {nextFrame.GetMethod().Name}");
                }
                else
                {
                    Console.WriteLine($"Привет! Я метод - {currentFrame.GetMethod().Name} и я никого не вызываю, я последний в цепочке вызова!");
                }
                
                i--;
            }
            
        }
    }
}
