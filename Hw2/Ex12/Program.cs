using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12
{
    /*
     * Внутри метода Main() последовательно сложите все 5 переменных в одну строку и выведите её в консоль.
     * Все элементы строки должны иметь корректные отступы слов друг от друга, а в конце строки должен стоять
     * восклицательный знак.
     * 
     * Значения переменных изменять нельзя.
     * 
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            string s1 = "Учи";
            string s2 = "С#, если хочешь";
            string s3 = "обеспечить себе";
            string s4 = "достойную";
            string s5 = "жизнь";

            Console.WriteLine($"{s1} {s2} {s3} {s4} {s5}!");
        }
    }
}