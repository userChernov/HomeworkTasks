using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    /*
     * Внутри метода Main() объявите три переменные типа string. Первой переменной 
     * присвойте значение "Васька", второй - "кота зовут", а третьей - "Моего любимого".
     * Выведите на экран фразу "Моего любимого кота зовут Васька" в одну строку.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            string a = "Васька";
            string b = "кота зовут";
            string c = "Моего любимого";

            Console.WriteLine($"{c} {b} {a}");
        }
    }
}