using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l9t4
{
    /*
     * Создайте 10 публичных статических методов, которые возвращают целое число, и принимают два целочисленных параметра: А и B.
     * Шаблон именования методов: RequestingMethodN, где N - порядковый номер метода, от 10 до 1.
     * Метод Main() вызывает метод RequestingMethod10() и передаёт ему соответствующие значения аргументов, а тот по цепочке должен 
     * вызывать метод с предыдущим порядковым номером, передать ему полученные значения при вызове, тот в свою очередь вызовет следующий и т.д. 
     * Последний метод должен вызывать метод AskResult(). 
     * Реализуйте метод AskResult() таким образом, чтобы он возвращал значение числа А в степени B.
     * Шаблон задачи изменять нельзя.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine(RequestingMethod10(5, 5));
        }

        /* Добавьте свой код ниже */
        public static int RequestingMethod10(int a, int b)
        {
            return RequestingMethod9(a, b);
        }
        public static int RequestingMethod9(int a, int b)
        {
            return RequestingMethod8(a, b);
        }
        public static int RequestingMethod8(int a, int b)
        {
            return RequestingMethod7(a, b);
        }
        public static int RequestingMethod7(int a, int b)
        {
            return RequestingMethod6(a, b);
        }
        public static int RequestingMethod6(int a, int b)
        {
            return RequestingMethod5(a, b);
        }
        public static int RequestingMethod5(int a, int b)
        {
            return RequestingMethod4(a, b);
        }
        public static int RequestingMethod4(int a, int b)
        {
            return RequestingMethod3(a, b);
        }
        public static int RequestingMethod3(int a, int b)
        {
            return RequestingMethod2(a, b);
        }
        public static int RequestingMethod2(int a, int b)
        {
            return RequestingMethod1(a, b);
        }
        public static int RequestingMethod1(int a, int b)
        {
            return AskResult(a, b);
        }

        public static int AskResult(int a, int b)
        {
            /* Добавьте свой код ниже */
            double dA = Convert.ToDouble(a);
            double dB = Convert.ToDouble(b);
            double pow = Math.Pow(dA, dB);

            return Convert.ToInt32(pow);
        }

    }
}
