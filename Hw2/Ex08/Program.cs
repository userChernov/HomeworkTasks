using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex08
{
    /*
     * Внутри метода Main() выведите в консоль значения всех переменных, каждое с новой строки.
     * 
     * Visual Studio Code в связке с расширениями становится мощным и современным редактором кода. Сегодня мы узнаем
     * чуть-чуть больше о её функциях и познакомимся с функцией автоматической генерации фрагментов кода.
     * Как видишь, нам предстоит в задаче сделать 5 выводов в консоль, для того чтобы сделать это быстрее, 
     * тебе достаточно:
     *      1) Установи указатель строки внутри метода Main() на новую строку.
     *      2) Напиши cw и нажми клавишу TAB или ENTER.
     *      3) Насладись результатом!
     *      
     * P.S. Таких фишек вагон, с самыми полезными из них мы будем знакомиться по мере необходимости.
     */

    public class Program
    {
        static string s1 = "А";
        static string s2 = "чо";
        static string s3 = "так";
        static string s4 = "можно";
        static string s5 = "было???";
        
        public static void Main(string[] args)
        {
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            Console.WriteLine(s5);
        }
    }
}
