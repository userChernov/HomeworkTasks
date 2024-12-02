using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex26
{
    /*
     * В классе Program добавьте публичное статическое поле deleteCount, которое должно увеличиваться каждый раз при уничтожении
     * экземпляра класса. Добавьте соответствующую логику деструктору класса Program
     */

    public class Program
    {
        /* Добавьте свой код ниже */
        public static int deleteCount = 0;

        ~Program()
        {
            deleteCount++;
            Console.WriteLine(deleteCount);
        }

        public static void Main(string[] args)
        {
            //Random rand = new Random();

            for (int i = 0; i < 10; i++)
            {

                Program test = new Program();
                
            }
            
            GC.Collect();
            GC.WaitForPendingFinalizers();
            Console.WriteLine($"Итого: {deleteCount}");
        }
    }
}