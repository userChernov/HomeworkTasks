using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l9t33
{
    /*
        * Расставьте в шаблоне задачи вызовы методов таким образом, чтобы в консоль была выведена знаменитая
        * английская поговорка "В гостях хорошо, а дома лучше" на языке оригинала. 
        * Остальные элементы шаблона задачи изменять нельзя.
        */

    public class Program
    {
        public static void Main(string[] args)
        {
            East();
        }

        public static void Best()
        {
            StackTrace currentStack = new StackTrace();
            for (int i = currentStack.GetFrames().Length - 2; i >= 0; i--)
            {
                Console.Write(currentStack.GetFrames()[i].GetMethod().Name + " ");
            }
        }

        private static void West()
        {
            /* Добавьте свой код ниже */
            Home();
        }

        internal static void Or()
        {
            /* Добавьте свой код ниже */
            West();
        }

        protected static void East()
        {
            /* Добавьте свой код ниже */
            Or();
        }

        internal protected static void Is()
        {
            /* Добавьте свой код ниже */
            Best();
        }

        static void Home()
        {
            /* Добавьте свой код ниже */
            Is();
        }
    }
}
