using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l7t1
{
   /*
    * Добавьте в динамический массив arr все статические поля класса Program.
    * Шаблон задачи изменять нельзя.
    */

    public class Program
    {
        static int a = 1;
        static double b = 2d;
        static string c = "3";
        static char d = '4';
        static float e = 5f;

        public static void Main(string[] args)
        {
            ArrayList arr = new ArrayList();
            /* Добавьте свой код ниже */

            for (int i = 0; i < arr.Count; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}

