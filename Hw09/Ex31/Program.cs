using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l9t31
{
    /*
     * Проанализируйте шаблон задачи. Сейчас при выводе информации из стектрейса служебная информация не соответствует действительности.
     * Определите причину и внесите соответствующие изменения в шаблон так, чтобы служебная информация стала отображаться корректно.
     */

    public class Program
    {
        public static void Main()
        {
            Call();
        }

        public static void Call()
        {
            Say();
        }

        public static void Say()
        {
            StackTrace currentStack = new StackTrace(true);
            for (int i = 0; i < currentStack.FrameCount; i++)
            {
                StackFrame stackFrame = currentStack.GetFrame(i);
                Console.WriteLine("Привет! Я метод - " + stackFrame.GetMethod().Name + "! Я располагаюсь на строке: " + stackFrame.GetFileLineNumber());
            }
        }
    }
}
