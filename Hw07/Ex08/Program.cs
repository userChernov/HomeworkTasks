using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l7t8
{
    /*
     * Внутри метода Main() дан список строк list. Реализуйте следующую логику работы со списком:
     *      1) Удалите из списка все слова, содержащие букву Т.
     *      2) Все слова содержащие букву Б сделайте в ВЕРХНЕМ РЕГИСТРЕ.
     *      3) Во всех словах, содержащих букву Р - замените её на букву Л.
     * Шаблон задачи изменять нельзя.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> list = new List<string>() { "собака", "улыбака", "мурка", "кот", "бурка", "Сивка", "баркаc" };
            /* Добавьте свой код ниже */
            string item;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Contains('Т') || list[i].Contains('т'))
                {
                    list.RemoveAt(i);
                }
                if (list[i].Contains('Б') || list[i].Contains('б'))
                {
                    list[i] = list[i].ToUpper();
                }
                if (list[i].Contains('Р') || list[i].Contains('р'))
                {
                    char[] letters = list[i].ToCharArray();

                    for (int j = 0; j < letters.Length; j++)
                    {
                        if (letters[j] == 'Р')
                            letters[j] = 'Л';
                        if (letters[j] == 'р')
                            letters[j] = 'л';
                    }

                    list[i] = new string(letters);
                }
            }

            foreach (var str in list)
            {
                Console.WriteLine(str);
            }
        }
    }
}

