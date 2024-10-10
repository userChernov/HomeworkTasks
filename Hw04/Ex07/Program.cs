using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex07
{
    /*
     * Реализуйте метод CheckNum(), который принимает в себя целое число 
     * и выводит на экран фразу «Число больше 7», если оно больше 7, 
     * «Число меньше 7», если оно меньше 7 или «Это 7!», если передана цифра 7.
     */
    public class Program
    {
        public static void Main()
        {
            CheckNum(11);
            CheckNum(7);
            CheckNum(-33);
        }

        public static void CheckNum(int num)
        {
            /* Добавьте свой код ниже */
            if (num > 7)
                Console.WriteLine("Число больше 7");
            else if (num < 7)
                Console.WriteLine("Число меньше 7");
            else 
                Console.WriteLine("Это 7!");

        }
    }
}