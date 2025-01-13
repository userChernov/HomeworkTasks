using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace l8t19
{
    /*
     *  Создайте метод AllSimple(), который принимает целое число Х, а возвращает массив всех простых чисел от 0 до Х включительно.
     */


    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */

            List<int> test = new List<int>();

            test = AllSimple(100);
            
            for (int i = 0; i < test.Count; i++)
            {
                Console.WriteLine(test[i]);
            }

        }

        public static List<int> AllSimple(int x)
        {
            List<int> simple = new List<int>();

            for (int i = 2; i < x + 1; i++)
            {
                bool isSimple = true;

                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isSimple = false;
                        break;
                    }
                }

                if (isSimple)
                    simple.Add(i);
                    
            }

            return simple;
        }
    }
}
