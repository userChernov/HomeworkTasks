using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l9t7
{
    /*
     * Внутри метода Main() спровоцировано возникновение исключения. Это одно из самых раздражающих исключений, которое может возникнуть.
     * Перехватите исключение и выведите на экран сведения о нём в следующем формате:
     * "Exception message: ХХХ! Exception name: XXX.", где ХХХ - соответствующие сведения о возникшем исключении.
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
                int[] arr = new int[] { 10, 11, 12, 123, 5 };
                Console.WriteLine(arr[1000]);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception message: {ex.Message}! Exception name: {ex.GetType()}.");
            }
        }
    }
}
