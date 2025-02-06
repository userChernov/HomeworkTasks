using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l9t27
{
    /*
     * Создайте статический метод GetCustomStack(), который:
     *      1) Принимает два стека строк.
     *      2) Возвращает стек строк, состоящий из элементов которые одновременно присутствовали в обоих принятых стеках.
     * Внутри метода Main() вызовите метод GetCustomStack(), передав ему в качестве аргумента переменные stackA и stackB.
     * Сохраните результат вызова в отдельную переменную и выведите все элементы получившегося стека на экран в одну строку
     * через пробел.
     * Шаблон задачи изменять нельзя.
     */

    public class Program
    {
        public static Stack<string> stackA = new Stack<string>(new string[] { "s", "i", "m", "p", "l", "e", " " });
        public static Stack<string> stackB = new Stack<string>(new string[] { "s", "t", "r", "i", "n", "g", "s", " " });

        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */

            Stack<string> customStack = GetCustomStack(stackA, stackB);

            while (customStack.Count > 0)
            {
                Console.Write($"{customStack.Pop()} ");
            }
        }
        /* Добавьте свой код ниже */

        public static Stack<string> GetCustomStack(Stack<string> stackA, Stack<string> stackB)
        {
            Stack<string> result = new Stack<string>();
            List<string> temp = new List<string>();
            string element = "";

            while (stackA.Count > 0)
            {
                temp.Add(stackA.Pop());
            }

            while (stackB.Count > 0)
            {
                element = stackB.Pop();

                if (temp.Contains(element))
                    result.Push(element);
            }

            return result;
        }
    }
}
