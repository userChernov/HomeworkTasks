using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l9t5
{
    /*
     * Внутри метода Main() спровоцировано возникновение исключения. Это одно из самых простых исключений, которое может возникнуть.
     * Перехватите исключение и выведите на экран его название. Шаблон задачи изменять нельзя.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Console.Clear();
            try
            {
                int a = 0;
                int b = 10;
                int c = b / a;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType());
            }

        }
    }
}
