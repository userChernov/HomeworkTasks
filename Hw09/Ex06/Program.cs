using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l9t6
{
    /*
     * Внутри метода Main() спровоцировано возникновение исключения. Это одно из самых частых исключений, которое может возникнуть.
     * Перехватите исключение и выведите на экран сведения о нём в следующем формате:
     * "Возникло исключение из namespace: ХХХ! Имя исключения: ХХХ.", где ХХХ - соответствующие сведения о возникшем исключении.
     * Шаблон задачи изменять нельзя.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Console.Clear();
            
            try
            {
                string s = null;
                Console.WriteLine(s.ToLower());
            }
            catch (Exception ex)
            {
                StackTrace current = new StackTrace();
                Console.WriteLine(current.FrameCount - 1);
                StackFrame frame = current.GetFrame(0);

                Console.WriteLine($"Возникло исключение из namespace: {ex.GetType().Namespace}! Имя исключения: {ex.GetType().Name}.");
            }

        }
    }
}
