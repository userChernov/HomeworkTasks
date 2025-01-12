using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace l8t9
{
    /*
     * Внутри метода Main() измените словарь keyWords таким образом, чтобы ключи стали значениями, а значения ключами.
     * Шаблон задачи изменять нельзя.
     */


    public class Program
    {
        public static Dictionary<string, string> keyWords = new Dictionary<string, string>();


        static Program()
        {
            keyWords.Add("янь", "инь");
            keyWords.Add("токанава", "тояма");
            keyWords.Add("весело", "быстро");
            keyWords.Add("Билли", "рядовой");
            keyWords.Add("молния", "гром");
        }
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */

            Dictionary<string, string> temp = new Dictionary<string, string>();

            foreach (var item in keyWords)
                temp.Add(item.Value, item.Key);

            keyWords.Clear();
            keyWords = temp;

            foreach (var item in keyWords)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
        }
    }
}
