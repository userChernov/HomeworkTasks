using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l9t9
{
    /*
     * Внутри метода Main() спровоцировано возникновение исключения.
     * Перехватите исключение и выведите на экран сведения о нём в следующем формате:
     * "Возникло исключение: XXX!", где ХХХ - имя исключения.
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
                Console.WriteLine(Int32.Parse("123q"));
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Возникло исключение: {ex.GetType().Name}!");
            }

        }
    }
}
