using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l7t20
{
    /*
     * Внутри метода Main() создайте список строк. Добавьте в созданный список 5 строк, считанных с клавиатуры.
     * Используя цикл foreach найдите самую длинную строку в списке. Выведите самую длинную строку на экран.
     * Если несколько строк имеют одинаковую максимальную длину, выведите каждую с новой строки.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            int numberOfWords = 5;
            int maxLengthWord = 1;

            List<string> stringsList = new List<string>();

            for (int i = 0; i < numberOfWords; i++)
            {
                string word = Console.ReadLine();
                stringsList.Add(word);
            }

            foreach (var item in stringsList)
            {
                if (item.Length > maxLengthWord)
                    maxLengthWord = item.Length;
            }

            foreach (var item in stringsList)
            {
                if (item.Length == maxLengthWord)
                    Console.WriteLine(item);
            }
            
        }
    }
}

