using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex14
{
    /*
     * В классе Program реализуйте статический метод GetRandomInt() так, чтобы он возвращал случайное
     * положительное трехзначное число, оканчивающееся на ноль.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
           System.Console.WriteLine(GetRandomInt());
        }

        public static int GetRandomInt()
        {
            /* Добавьте свой код ниже */
            int num = 0;
            bool a = true;
            Random rand = new Random();

            while (a)
            {
                num = Convert.ToInt32(rand.Next());

                if (num > 0 && num > 100 && (float)num % 10 == 0)
                {
                    a = false;
                }
                
            }

            return num;


        }
    }
}
