using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l9t28
{
    /*
     * Создайте статический метод GetFreshStack(), который:
     *      1) Принимает два стека строк.
     *      2) Возвращает стек строк в который должны быть включены по одному разу элементы, которые входят в stackA, но не входят в стек stackB.
     * Внутри метода Main() вызовите метод GetFreshStack(), передав ему в качестве аргумента переменные stackA и stackB.
     * Сохраните результат вызова в отдельную переменную и выведите все элементы получившегося стека на экран в одну строку через пробел.
     * Шаблон задачи изменять нельзя.
     */

    public class Program
    {
        public static Stack<string> stackA = new Stack<string>(new string[] { "l", "o", "o", "k", "m", "o", "m" });
        public static Stack<string> stackB = new Stack<string>(new string[] { "i", "a", "m", "p", "r", "o", "g", "r", "a", "m", "m", "e", "r" });

        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */

            Stack<string> freshStack = GetFrashStack(stackA, stackB);

            while (freshStack.Count > 0)
            {
                Console.Write($"{freshStack.Pop()} ");
            }

        }
        /* Добавьте свой код ниже */

        public static Stack<string> GetFrashStack(Stack<string> stackA, Stack<string> stackB)
        {
            Stack<string> result = new Stack<string>();
            
            HashSet<string> setA = new HashSet<string>();
            HashSet<string> setB = new HashSet<string>();
            string element = "";

            while (stackB.Count > 0)
            {
                setB.Add(stackB.Pop());
            }

            while (stackA.Count > 0)
            {
                element = stackA.Pop();

                if (!setB.Contains(element))
                    setA.Add(element);
            }

            foreach (string item in setA)
            {
                result.Push(item);
            }

            return result;
        }

    }
}
