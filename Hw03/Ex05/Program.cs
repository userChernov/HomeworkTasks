using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    /*
     * Закомментируйте правильные строчки, чтобы в консоль была выведена фраза "Собака - друг человека!" в одну строку.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            string s = "Собака";
            Console.Write(s);
            //Console.WriteLine("Собака ");
            //Console.Write(" Собака ");
            Console.Write(" -");
            //Console.WriteLine(" -");
            //Console.Write(" ");
            //Console.WriteLine("друг");
            Console.Write(" друг ");
            //Console.Write(" ");
            //Console.WriteLine("человека");
            Console.WriteLine("человека!");
        }
    }
}