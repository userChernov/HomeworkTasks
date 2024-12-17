using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l7t12
{
    /*
     * Внутри метода Main() создайте программу, которая бы реализовывала следующую логику работы:
     *      1) Создавала и инициализировала список строк.
     *      2) Считывала строки с клавиатуры и помещала бы их в список до тех пор, пока не будет введена
     *      строка "конец".
     *      3) После завершения ввода, выводила бы все строки списка в консоль (каждую с новой строки).
     * Строку "конец", добавлять в список не нужно.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */

            bool isContinueWriting = true;
            List<string> listString = new List<string>();

            while (isContinueWriting)
            {
                Console.Write("Введите строку: ");
                string word = Console.ReadLine();

                if (!Equals(word, "конец"))
                    listString.Add(word);
                else isContinueWriting = false;
            }

            foreach (var word in listString)
                Console.WriteLine(word);                


        }
    }
}

