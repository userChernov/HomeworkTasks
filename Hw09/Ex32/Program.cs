using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace l9t32
{
    /*
     * Выведите информацию для кадра метода Say в следующем формате:
     * "Я метод XXX и я нахожусь в файле: YYY", где XXX - имя метода, а YYY - полное имя файла, в котором он объявлен. 
     * Изменять сигнатуру созданных методов или менять последовательность их вызова нельзя.
     */

    public class Program
    {
        public static void Main()
        {
            I();
        }

        public static void I()
        {
            Just();
        }

        public static void Just()
        {
            Call();
        }

        public static void Call()
        {
            To();
        }

        public static void To()
        {
            Say();
        }

        public static void Say()
        {
            Hello();
        }

        public static void Hello()
        {
            StackTrace currentStack = new StackTrace(true);
            for (int i = 0; i < currentStack.FrameCount; i++)
            {
                StackFrame stackFrame = currentStack.GetFrame(i);
                Console.WriteLine($"Я метод {stackFrame.GetMethod().Name} и я нахожусь в файле {stackFrame.GetFileName()}");
            }
        }
    }
}
