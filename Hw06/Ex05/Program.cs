using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l6t5
{
    /*
     * Проанализируйте шаблон и измените метод Sum таким образом, чтобы после его вызова в шаблоне локальная переменная х метода Main() стала равна 77.
     * Остальные элементы шаблона задачи менять нельзя.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            int x = 57;
            int y = 20;
            Sum(ref x, y);
            Console.WriteLine(x);
        }

        static void Sum(ref int x, int y)
        {
            x = x + y;
        }
    }
}
