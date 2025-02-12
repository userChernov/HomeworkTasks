using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l9t8
{
    /*
     * Внутри метода Main() спровоцировано возникновение исключения.
     * Перехватите исключение и выведите на экран сведения о нём в следующем формате:
     * "Exception name: XXX! Exception message: ХХХ...", где ХХХ - соответствующие сведения о возникшем исключении.
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
                List<int> list = new List<int>() { 1, 2, 3, 4, 5 };
                Console.WriteLine(list[17]);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception name: {ex.GetType().Name}! Exception message: {ex.Message}...");
            }
        }
    }
}
